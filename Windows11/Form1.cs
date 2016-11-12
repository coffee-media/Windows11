using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Windows11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "You cannot close this operation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

            MessageBox.Show(message, " " , buttons);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            //Start the Timer
            this.timer1.Start();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string message = "You cannot close this operation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

            MessageBox.Show(message, " ", buttons);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                this.timer1.Stop();

                string message = "Windows 11 install complete computer will now restart";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, " ", buttons);

                System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
            }
        }

    }
}
