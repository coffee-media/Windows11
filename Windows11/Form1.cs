using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "You cannot close this operation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

            MessageBox.Show(message, " ", buttons);
        }
    }
}
