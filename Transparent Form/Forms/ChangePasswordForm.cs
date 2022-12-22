using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transparent_Form.Models;

namespace Transparent_Form.Forms
{
    public partial class ChangePasswordForm : Form
    {
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

        public ChangePasswordForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void button_savePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPass.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtCheckNewPass.Text))
            {
                MessageBox.Show("Please fill in all fields", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                      

            if (DataProvider.account.password != txtCurrentPass.Text)
            {
                MessageBox.Show("Current password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNewPass.Text != txtCheckNewPass.Text)
            {
                MessageBox.Show("The Confirm New Password confirmation does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCurrentPass.Text.Length < 6 || txtNewPass.Text.Length < 6 || txtCheckNewPass.Text.Length < 6)
            {
                MessageBox.Show("Passwords must be at least 6 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                 

            if (DataProvider.account.UpdatePassword(txtNewPass.Text))
            {
                MessageBox.Show("Update successfully!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
