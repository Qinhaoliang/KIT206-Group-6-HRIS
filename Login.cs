using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(LoginNameTextBox.Text.Trim().Equals("Admin") && PasswordTextBox.Text.Trim().Equals("123456"))
            {
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("User name or password input error!");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
