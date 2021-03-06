﻿using Kolejki3.Logika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolejki3
    {
    public partial class Form1 : Form
        {
        List<Modul> listaModulow;
        public List<Zdarzenie> listaZdarzen;
        public List<Komunikat> listaWydarzen;
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
            backgroundWorker1.WorkerSupportsCancellation = true;
            }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
            {
            queuesEngine.run((int)numericUpDown1.Value);
            }
            
        private void simStart(object sender, EventArgs e)
            {
            if (listaModulow.Count > 0)
                {
                Console.Out.WriteLine("logi:");
                startEngine(listaModulow, listaZdarzen, listaWydarzen);
                }
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
                        control.MouseDown += ModulControl_MouseDown;
                        control.MouseMove += ModulControl_MouseMove;
                        control.MouseUp += ModulControl_MouseUp;
                        panelMain.Controls.Add(control);

                        } break;
                }
            Console.WriteLine();
                
            Invalidate();

            }

        private void ModulControl_MouseDown(object sender, MouseEventArgs e)
            {
            _lastPoint = e.Location;
            Control c = sender as Control;
            c.Cursor = Cursors.SizeAll;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
            SelectedModules++;

            button4.Visible = true;
                ModulControl md = sender as ModulControl;
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
                    if (m.listConnections == null)
                        {
                        ListaPolaczen pol = new ListaPolaczen(new Polaczenie(listaModulow.FirstOrDefault(x => x.ID == _lastId), listaModulow.FirstOrDefault(x => x.ID == _newId), f.Probability, _lastPoint, _newPoint));
                        m.listConnections = pol;
                        }
                    else
                        {
                        m.listConnections.Add(new Polaczenie(listaModulow.FirstOrDefault(x => x.ID == _lastId), listaModulow.FirstOrDefault(x => x.ID == _newId), f.Probability, _lastPoint, _newPoint));
                        }

                    }
                SelectedModules = 0;
                }
            listBox1.Items.Clear();
            foreach (Modul m in listaModulow)
                {
                foreach (Polaczenie p in m.listConnections ?? Enumerable.Empty<Polaczenie>())
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

        private void startEngine(List<Modul> lm, List<Zdarzenie> lz, List<Komunikat> lw)
            {
            
            listaWydarzen = new List<Komunikat>();
            listaZdarzen = new List<Zdarzenie>();
            akcjeBox.DataSource = null;
            backgroundWorker1.CancelAsync();
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.WorkerSupportsCancellation = true;
           
           
           
                queuesEngine = new Engine(lm, lz, lw, float.Parse(textBoxMi.Text), this, float.Parse(textBoxLambda.Text));
            
                //if (pomButtonClickCount < 1)
                //{
                    //queuesEngine.run(100);          // <--- tu ustaw czas zakończenia symulacji.
                //queuesEngine._END_MODUL = 1; // jesli ma być tylko jeden moduł
                    queuesEngine._END_MODUL = listaModulow.Count-1; // jeśli mają być dwa moduły
                    ((ModulControl)panelMain.Controls[queuesEngine._END_MODUL]).end();
                    queuesEngine.OnProgressUpdate+=queuesEngine_OnProgressUpdate;
                backgroundWorker1.RunWorkerAsync();
                    
                   // queuesEngine.run(50);          // <--- tu ustaw czas zakończenia symulacji.
                //}
            
                pomButtonClickCount++;
                Console.Out.WriteLine("count: " + pomButtonClickCount);
            }

        private void queuesEngine_OnProgressUpdate(List<Komunikat> list, string s1, string s2, string s3, string s4)
            {
            base.Invoke((Action)delegate
                {
                    this.aqt.Text = s2;
                    this.aio.Text = s1;
                    this.absPerf.Text = s3;
                    this.relativePerf.Text = s4;
                    this.akcjeBox.DataSource = null;
                    this.akcjeBox.DataSource = list;
                    this.akcjeBox.DisplayMember = "Out";


                    for (int i = 0; i < listaModulow.Count; i++)
                        {
                        ModulControl m = panelMain.Controls[i] as ModulControl;
                        if (m != null)
                            {
                            m.currentInBuffer.Text = "Ile w kolejce: " + listaModulow[i].buffer.CurrentSize.ToString();
                            string inmachine = "Zajęte maszyny: ";
                            
                            for (int x = 0; x < listaModulow[i].machins.Count; x++)
                                {
                                if (!listaModulow[i].machins[x].isEmpty())
                                    {
                                    inmachine += x + " ";
                                    }
                                }
                            m.currentInMachine.Text = inmachine;
                            
                            }

                        }

                  });
            }

        private void button3_Click(object sender, EventArgs e)
            {
            queuesEngine.Simulating = false;
            }

        private void button4_Click(object sender, EventArgs e)
            {
            ModulControl md = sender as ModulControl;
            listaModulow.RemoveAt(_newId);
            panelMain.Controls.RemoveAt(_newId);
            button4.Visible = false;
            }

        private void button5_Click(object sender, EventArgs e)
            {
            listaModulow = new List<Modul>();
            listaWydarzen = new List<Komunikat>();
            listaZdarzen = new List<Zdarzenie>();
            panelMain.Controls.Clear();
            panelMain.Invalidate();
            listBox1.Items.Clear();
            akcjeBox.DataSource = null;
            queuesEngine = null;
            }

        private void label11_Click(object sender, EventArgs e)
            {

            }


        }
    }
