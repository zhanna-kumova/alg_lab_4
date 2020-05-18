using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alg_lab_4
{
    public partial class Lab4 : Form
    {
        public int milisec, sec, min;
        public Lab4()
        {
            InitializeComponent();
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void reset_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            milisec = 0;
            sec = 0;
            min = 0;
            timer1.Enabled = false;
            label1.Text = "0:0:0";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            milisec += 1;
            if (milisec == 10) {
                milisec = 0;
                sec += 1;
            }
            if (sec == 60) {
                sec = 0;
                min += 1;
            }
            label1.Text = min + ":" + sec + ":" + milisec;
        }
    }
}
