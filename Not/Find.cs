using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Form1.matchcase = true;
            }
            else {
                Form1.matchcase = false;
            }
                
            Form1.findtext = textBox1.Text;

            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.findtext = "";

            this.Close();

        }
    }
}
