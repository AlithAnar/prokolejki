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
    public partial class ProbabForm : Form
        {
        public float Probability { get; set; }

        public ProbabForm()
            {
            InitializeComponent();
            Probability = 0;
            }

        private void button1_Click(object sender, EventArgs e)
            {
            float tmp = 0;
            var val = float.TryParse(textBox1.Text, out tmp);
            if (val)
                {
                Probability = tmp;
                }
            else
                {
                MessageBox.Show("Popraw dane");
                }
            }
        }
    }
