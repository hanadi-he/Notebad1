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
    public partial class Form1 : Form
    {
        public static string findtext;
        public static string ReplaceText;
        string path="";
        public static Boolean matchcase;

        int d;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (path == "")
                {
                    var r = MessageBox.Show("هل تريد الحفظ", "notepad", MessageBoxButtons.YesNoCancel);
                    if (r == System.Windows.Forms.DialogResult.Yes)
                    {
                        saveToolStripMenuItem1_Click(sender, e);

                    }
                    else if (r == System.Windows.Forms.DialogResult.No)
                    {
                        richTextBox1.Clear();
                    }
                }
                else
                {
                    richTextBox1.Clear();

                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "all text('.Rs)|'.Rs";
            openFileDialog1.FileName = "";
           var d= openFileDialog1.ShowDialog();
           if (d == System.Windows.Forms.DialogResult.OK)
           {
               richTextBox1.LoadFile(openFileDialog1.FileName);
               path = openFileDialog1.FileName;
               this.Text = path;
           }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (path != "")
            {

                richTextBox1.SaveFile(path);
            }
            else
            {


                saveFileDialog1.Filter = "all text(.rs)|>rs";
                var r = saveFileDialog1.ShowDialog();
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    path = saveFileDialog1.FileName;
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {


                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                selectALLToolStripMenuItem.Enabled=true;
            }
            else {

                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                selectALLToolStripMenuItem.Enabled = false;
            }

        }

        private void selectALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.ToString();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find r=new Find();
            r.ShowDialog();
            if (findtext != "")
            {
              d=richTextBox1.Find(findtext);
            }

        }

        private void findNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (findtext != "") 
            {
                if (matchcase == true)
                {
                    d = richTextBox1.Find(findtext, (d + 1), richTextBox1.Text.Length, RichTextBoxFinds.MatchCase);
                }
                else
                {
                    d = richTextBox1.Find(findtext, (d + 1), richTextBox1.Text.Length, RichTextBoxFinds.None);
                }
            }

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace r = new Replace();
            r.ShowDialog();
            richTextBox1.Find(findtext);
            richTextBox1.SelectedText = ReplaceText;
        }

        private void wordWarpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap == true)
            {
                richTextBox1.WordWrap = false;
            }
            else {
                richTextBox1.WordWrap = true;
            
            }
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void selectedFontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;

        }

        private void selectedBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;

        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application is created by Hanadi.This is only for learning purpose, Anyone can try this and Use this","About Notepad",MessageBoxButtons.OK,MessageBoxIcon.Information);
          

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thanks");
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void catToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(sender, e);
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, e);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(sender, e);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (path == "")
            {
                var r = MessageBox.Show("هل تريد الحفظ", "notepad", MessageBoxButtons.YesNoCancel);
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem1_Click(sender, e);
                    
                }
                else if (r == System.Windows.Forms.DialogResult.No)
                {
                    richTextBox1.Clear();
                }
            }
            

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
