using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kolejki3.Logika;

namespace Kolejki3
    {
    public partial class ModulControl : UserControl
        {
        private Modul _modul;
        public int ID
            {
            get
                {
                return _modul.ID;
                }

            }
        public ModulControl(Modul modul)
            {
            this._modul = modul;

            InitializeComponent();
            label1.Text = "Maszyny: " + _modul.machins.Count;
            label2.Text = "Dł. kolejki " + _modul.buffer.MaxSize;
            label3.Text = "W kolejce: ";
            label4.Text = "W maszynie: ";
            label5.Text = "Reguła: " + _modul.buffer.getRuleType();
            label6.Text = "M: ";
            labeId.Text = "ID: " + _modul.ID;
            }


        }
    }
