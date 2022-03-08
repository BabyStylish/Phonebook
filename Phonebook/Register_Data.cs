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

namespace Phonebook
{
    public partial class Register_Data : Form
    {
        public Register_Data()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.btnNewData.Enabled = false;
            this.btnSaveChanges.Enabled = true;
            this.infoGroupBox.Enabled = true;

            //Clear textboxes
            txtAddress.Text = "";
            txtComment.Text = "";
            txtEmail.Text = "";
            txtFName.Text = "";
            txtID.Text = "";
            txtLName.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            this.btnNewData.Enabled = true;
            this.btnSaveChanges.Enabled = false;
            this.infoGroupBox.Enabled = false;

            string fn = "D:\\VS_Repo\\Phonebook\\Phonebook\\Text\\";
            string p = fn + txtID.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, txtID.Text + Environment.NewLine + txtFName.Text + Environment.NewLine + txtLName.Text + Environment.NewLine + txtPhoneNumber.Text + Environment.NewLine 
                + txtEmail.Text + Environment.NewLine + txtAddress.Text + Environment.NewLine + txtComment.Text + Environment.NewLine + "----------------------------"
                , Encoding.UTF8);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtComment.Text = "";
            txtEmail.Text = "";
            txtFName.Text = "";
            txtID.Text = "";
            txtLName.Text = "";
            txtPhoneNumber.Text = "";
        }
    }
}
