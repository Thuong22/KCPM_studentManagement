using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Transparent_Form.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Transparent_Form
{
    public partial class LoginForm : Form
    {

        #region DragForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Make rounded form 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        #endregion

        #region Drop Shadow
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        Account account;

        public LoginForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            this.ActiveControl = txtUsername;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtPassword;
            }
            else
            {
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                account = new Account();
                account = account.GetAccount(user, pass);

                if (account != null)
                {
                    if (account.type == 1)
                    {
                        Thread thread = new Thread(new ThreadStart(ShowAdminForm));
                        thread.Start();
                        this.Close();
                    }
                    else if (account.type == 2)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Your username and password are not exists", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = txtUsername;
                }
            }
        }

        private void ShowAdminForm()
        {
            AdminForm.account = account;
            new AdminForm().ShowDialog();
        }

        private void ShowStudentForm()
        {
            //this.Close();
            //AdminForm form = new AdminForm();
            //form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
