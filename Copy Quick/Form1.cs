using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Copy_Quick
{
    public partial class Form1 : Form
    {
        public static string fileName { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //When the user clicks the open file dialog option
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                fileName = Path.GetFileName(ofd.FileName);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Sahil Kajani", "About");
        }

        private void versioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0", "Version");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //When the user clicks on SaveFile dialog
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = fileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = sfd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e) //When the user clicks on Copy button
        {
            string source = textBox1.Text;
            string destination = textBox2.Text;

            System.IO.File.Copy(source, destination);
            MessageBox.Show("File Copied Successfully", "File Copied");
        }

        private void button5_Click(object sender, EventArgs e) //When the user clicks on Move button
        {
            string source = textBox1.Text;
            string destination = textBox2.Text;
            bool exists = System.IO.File.Exists(source);
            if (exists)
            {
                System.IO.File.Move(source, destination);
                System.IO.File.Delete(source);
                MessageBox.Show("File Moved Successfully", "File Moved");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
