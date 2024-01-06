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
    public partial class LOGIN : Form
    {

        private BUS.LOGIN loginBUS;

        public LOGIN()
        {
            loginBUS = new BUS.LOGIN();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username, user_password;
            username = Username.Text.ToString();
            user_password = PassWord.Text.ToString();

            DataTable dtUser = loginBUS.getUser(username, user_password);

            if (dtUser.Rows.Count > 0)
            {
                MAIN form = new MAIN(dtUser.Rows[0]["MA_QUYEN"].ToString().Trim());
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
