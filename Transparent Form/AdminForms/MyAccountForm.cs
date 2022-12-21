﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transparent_Form.Models;

namespace Transparent_Form.Forms
{
    public partial class MyAccountForm : Form
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
        public MyAccountForm()
        {
            InitializeComponent();
            pnlMain.BringToFront();

            LoadInfomationAccount();
        }

        private void LoadInfomationAccount()
        {
            //label1_username.Text = AccountClass.account.username + ",";

            //textBox_id.Text = AccountClass.account.accId.ToString();
            //textBox_Username.Text = AccountClass.account.username;
            //textBox_password.Text = AccountClass.account.password;
            //comboBox_type.SelectedIndex = AccountClass.account.type - 1;

            lbName.Text = DataProvider.account.accFirstName + " " + DataProvider.account.accLastName;
            lbGender.Text = DataProvider.account.gender;
            lbBirth.Text = DataProvider.account.birthdate.ToShortDateString();
            lbPhone.Text = DataProvider.account.phone;
            lbAddress.Text = DataProvider.account.address;
            byte[] img;
            try
            {
                img = (byte[])DataProvider.account.photo;
                MemoryStream ms = new MemoryStream(img);
                pbImage.Image = Image.FromStream(ms);
            }
            catch
            {
                img = null;
                pbImage.Image = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //pnlWindown2.BringToFront();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.ShowDialog();
        }


        #region Validation
        public bool CheckEmptyField(string lname, string fname, string phone, string address)
        {
            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                return false;
            }
            else
                return true;
        }

        public bool CheckBirthday(DateTime birthday)
        {
            int born_year = birthday.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                return false;
            else
                return true;
        }
        #endregion

        //private void btnUpload_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog opf = new OpenFileDialog();
        //    opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

        //    if (opf.ShowDialog() == DialogResult.OK)
        //        pbImg.Image = Image.FromFile(opf.FileName);
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    DataProvider.account.accFirstName = txtFName.Text;
        //    DataProvider.account.accLastName = txtLName.Text;
        //    DataProvider.account.birthdate = dtpBirth.Value;
        //    DataProvider.account.phone = txtPhone.Text;
        //    DataProvider.account.address = txtAddress.Text;
        //    string gender = rbMale.Checked ? "Male" : "Female";

        //    if (!CheckBirthday(dtpBirth.Value))
        //    {
        //        MessageBox.Show("Age of student must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (CheckEmptyField(txtFName.Text, txtLName.Text, txtPhone.Text, txtAddress.Text))
        //    {
        //        try
        //        {
        //            byte[] img;
        //            if (pbImg.Image != null)
        //            {
        //                MemoryStream ms = new MemoryStream();
        //                pbImg.Image.Save(ms, pbImg.Image.RawFormat);
        //                img = ms.ToArray();
        //                DataProvider.account.photo = img;
        //            }
        //            else
        //            {
        //                img = null;
        //            }

        //            if (DataProvider.account.UpdateMyAccount(txtFName.Text, txtLName.Text, dtpBirth.Value, gender, txtPhone.Text, txtAddress.Text, img))
        //            {
        //                MessageBox.Show("Update successfully!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
        //                LoadInfomationAccount();
        //                pnlMain.BringToFront();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please fill in all fields", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;

        //    }
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    LoadInfomationAccount();
        //    pnlMain.BringToFront();
        //}


    }
}