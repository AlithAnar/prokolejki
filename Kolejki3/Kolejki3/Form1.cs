using Kolejki3.Logika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolejki3
    {
    public partial class Form1 : Form
        {
        List<Modul> listaModulow;
        public List<Zdarzenie> listaZdarzen;
        List<String> listaWydarzen;
        Engine queuesEngine;
        private Point _lastPoint, _newPoint;
        private int _lastId = -1, _newId = -1;

        private int pomButtonClickCount = 0;


        public int SelectedModules { get; set; }
        public Form1()
            {
            InitializeComponent();
            listaModulow = new List<Modul>();
            SelectedModules = 0;
            }

        private void simStart(object sender, EventArgs e)
            {
               
            }

        private void createModule(object sender, EventArgs e)
            {
            if (!((int)numericUpDownMachineCount.Value > 0) || comboBoxTypes.SelectedIndex.Equals(-1) || !((int)numericUpDownQueueSize.Value > 0)) return;
            ListaMaszyn listaMaszyn = new ListaMaszyn();
            for (int i = 0; i < (int)numericUpDownMachineCount.Value; i++)
                {
                Maszyna m = new Maszyna();
                listaMaszyn.Add(m);
                }
            Kolejka k;
            Modul modul = null;
            switch (comboBoxTypes.SelectedIndex)
                {
                case 0:
                        {
                        k = new FIFO((int)numericUpDownQueueSize.Value);
                        modul = new Modul(listaMaszyn, k);
                        modul.ID = listaModulow.Count;
                        listaModulow.Add(modul);
                        ModulControl control = new ModulControl(modul);
                        control.connector1.MouseDown += addConnection;
                        control.connector2.MouseDown += addConnection;
                        control.connector3.MouseDown += addConnection;
                        control.connector4.MouseDown += addConnection;
                        control.MouseDown += ModulControl_MouseDown;
                        control.MouseMove += ModulControl_MouseMove;
                        control.MouseUp += ModulControl_MouseUp;
                        panelMain.Controls.Add(control);
                        } break;
                case 1:
                        {
                        k = new LIFO((int)numericUpDownQueueSize.Value);
                        modul = new Modul(listaMaszyn, k);
                        modul.ID = listaModulow.Count;
                        listaModulow.Add(modul);
                        ModulControl control = new ModulControl(modul);
                        control.connector1.MouseDown += addConnection;
                        control.connector2.MouseDown += addConnection;
                        control.connector3.MouseDown += addConnection;
                        control.connector4.MouseDown += addConnection;
                        control.MouseDown += ModulControl_MouseDown;
                        control.MouseMove += ModulControl_MouseMove;
                        control.MouseUp += ModulControl_MouseUp;
                        panelMain.Controls.Add(control);

                        } break;
                }
            Invalidate();

            }

        private void addConnection(object sender, MouseEventArgs e)
            {
            SelectedModules++;

            Control c = sender as Control;
            ModulControl md = c.Parent as ModulControl;
            _lastId = _newId;
            _lastPoint = _newPoint;
            _newPoint = md.Location;
            _newId = md.ID;
            if (SelectedModules == 2)
                {
                ProbabForm f = new ProbabForm();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                    Modul m = listaModulow.FirstOrDefault(x => x.ID == _lastId);
                    if (m.polaczenia == null)
                        {
                        ListaPolaczen pol = new ListaPolaczen(new Polaczenie(listaModulow.FirstOrDefault(x => x.ID == _lastId), listaModulow.FirstOrDefault(x => x.ID == _newId), f.Probability, _lastPoint, _newPoint));
                        m.polaczenia = pol;
                        }
                    else
                        {
                        m.polaczenia.Add(new Polaczenie(listaModulow.FirstOrDefault(x => x.ID == _lastId), listaModulow.FirstOrDefault(x => x.ID == _newId), f.Probability, _lastPoint, _newPoint));
                        }

                    }
                SelectedModules = 0;
                }
            listBox1.Items.Clear();
            foreach (Modul m in listaModulow)
                {
                foreach (Polaczenie p in m.polaczenia ?? Enumerable.Empty<Polaczenie>())
                    {
                    listBox1.Items.Add("M: " + p.ModulIn.ID + " M: " + p.ModulOut.ID);
                    Graphics g = panelMain.CreateGraphics();
                    using (var pen = new Pen(Color.Blue, 2))
                        {
                        g.DrawLine(pen, p.Point1, p.Point2);
                        }
                    }
                }
            }

        private void ModulControl_MouseDown(object sender, MouseEventArgs e)
            {
            _lastPoint = e.Location;
            Control c = sender as Control;
            c.Cursor = Cursors.SizeAll;
            }

        private void ModulControl_MouseUp(object sender, MouseEventArgs e)
            {
            Control c = sender as Control;
            c.Cursor = Cursors.Default;
            }

        private void ModulControl_MouseMove(object sender, MouseEventArgs e)
            {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                Control c = sender as Control;
                c.Location = new Point(c.Location.X + (e.X - _lastPoint.X), c.Location.Y + (e.Y - _lastPoint.Y));
                }
            }

        private void panelMain_Paint(object sender, PaintEventArgs e)
            {

            }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Console.Out.WriteLine("logi:");

            if (listaModulow.Count > 0)
            {
                startEngine(listaModulow, listaZdarzen, listaWydarzen);
            }
        }

        private void startEngine(List<Modul> lm, List<Zdarzenie> lz, List<String> lw)
        {
            queuesEngine = new Engine(lm, lz, lw);

            
            if (pomButtonClickCount < 1)
            {
                queuesEngine.run(3);
            }
            
            pomButtonClickCount++;
            Console.Out.WriteLine("count: " + pomButtonClickCount);
        }





        }
    }
