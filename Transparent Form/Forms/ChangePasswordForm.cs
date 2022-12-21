using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transparent_Form.Models;

namespace Transparent_Form.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
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
