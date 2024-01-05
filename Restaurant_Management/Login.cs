using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "Your_user_name" && PassWord.Text == "Your_Password")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect, please try again");
                Username.Clear();
                PassWord.Clear();
                Username.Focus();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Username.Clear();
            PassWord.Clear();
            Username.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
