﻿using System;
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
    public partial class Replace : Form
    {
        public Replace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.findtext = textBox1.Text;
            Form1.ReplaceText = textBox2.Text;
            this.Close();
        }
    }
}
