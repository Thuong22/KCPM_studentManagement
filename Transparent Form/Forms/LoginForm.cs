using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Transparent_Form
{
    public partial class LoginForm : Form
    {
       // AccountClass account = new AccountClass();
        public LoginForm()
        {
            InitializeComponent();
            textBox_usrname.Focus();
            this.AcceptButton = button_login;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_usrname.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string uname = textBox_usrname.Text;
                string pass = textBox_password.Text;
                bool flag = AccountClass.account.getMyAccount("SELECT * FROM `account` WHERE `Username`= '" + uname + "' AND `Password`='" + pass + "'");
                if (flag)
                {
                    Form main;
                    if (AccountClass.account.type == 1)
                    {
                        main = new MainFormAdmin();
                    }
                    else
                    {
                        main = new MainFormStudent();
                    }
                    
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                    textBox_usrname.Text = "";
                    textBox_password.Text = "";
                    textBox_usrname.Focus();
                }
                else
                {
                    MessageBox.Show("Your username and password are not exists", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }

        }
    }
}
