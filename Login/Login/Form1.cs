using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enter.Enabled = false;
        }

        private void text_textChanged(object sender, EventArgs e)
        {
            enter.Enabled = textUser.Text != "" && textPassword.Text != "" ? true : false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textPassword.Focus();
            }
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enter.Focus();
            }
        }
        private void enter_Click(object sender, EventArgs e)
        {   if (!enter.Enabled) return;

            string user = textUser.ToString();
            string password = textPassword.ToString();
            MessageBox.Show("Welcome, " + textUser.Text + "!");
        }
    }
}
