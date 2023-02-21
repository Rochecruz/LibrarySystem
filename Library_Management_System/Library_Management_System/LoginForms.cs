using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class LoginForms : Form
    {
        public LoginForms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "roche";
            string password = "cruz08";

            MainForm main = new MainForm();
            if (textBox1.Text.Equals(username)&& textBox2.Text.Equals(password))

            {
                MessageBox.Show("Login Successfully!", "Success!");
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password! Try Again!", "ERROR!");

            }
            
        }
    }
}
