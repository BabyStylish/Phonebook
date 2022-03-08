using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Register_Data rg = new Register_Data();
            rg.MdiParent = this;
            rg.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search sr = new Search();
            sr.MdiParent = this;
            sr.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            About_Us au = new About_Us();
            au.MdiParent = this;
            au.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
    }
}
