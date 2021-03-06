﻿using System;
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
            lengthText.Text = "Dł. kolejki " + _modul.buffer.MaxSize;
            currentInBuffer.Text = "W kolejce: ";
            currentInMachine.Text = "W maszynie: ";
            label5.Text = "Reguła: " + _modul.buffer.getRuleType();
            labeId.Text = "ID: " + _modul.ID;
            }

        public void end()
            {
            label1.Visible = false;
            lengthText.Visible = false;
            currentInBuffer.Visible = false;
            currentInMachine.Visible = false;
            label5.Visible = false;
            labeId.Visible = false;
            label2.Visible = true;
            }

        }
    }
