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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text == "")
            {
                MessageBox.Show("You must insert the ID!");
                return;
            }
            else
            {
                bool fileExists = System.IO.File.Exists("D:\\VS_Repo\\Phonebook\\Phonebook\\Text\\" + txtSearch.Text + "_fn.txt");
                if (fileExists == true)
                {
                    string[] lines = System.IO.File.ReadAllLines("D:\\VS_Repo\\Phonebook\\Phonebook\\Text\\" + txtSearch.Text + "_fn.txt");
                    txtID.Text = lines[0];
                    txtFName.Text = lines[1];
                    txtLName.Text = lines[2];
                    txtPhoneNumber.Text = lines[3];
                    txtEmail.Text = lines[4];
                    txtAddress.Text = lines[5];
                    txtComment.Text = lines[6];

                }
                else
                {
                    MessageBox.Show("File not found!");
                }
            }
        }
    }
}
