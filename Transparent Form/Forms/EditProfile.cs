using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transparent_Form.Models;

namespace Transparent_Form.Forms
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            txtFName.Text = DataProvider.account.accFirstName;
            txtLName.Text = DataProvider.account.accLastName;
            if (DataProvider.account.gender == "Male")
               rbMale.Checked = true;
            dtpBirth.Text = DataProvider.account.birthdate.ToShortDateString();
            txtPhone.Text = DataProvider.account.phone;
            txtAddress.Text = DataProvider.account.address;
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pbImage.Image = Image.FromFile(opf.FileName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {         
            DataProvider.account.accFirstName = txtFName.Text;
            DataProvider.account.accLastName = txtLName.Text;
            DataProvider.account.birthdate = dtpBirth.Value;
            DataProvider.account.phone = txtPhone.Text;
            DataProvider.account.address = txtAddress.Text;
            string gender = rbMale.Checked ? "Male" : "Female";

            if (!CheckBirthday(dtpBirth.Value))
            {
                MessageBox.Show("Age of student must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckEmptyField(txtFName.Text, txtLName.Text, txtPhone.Text, txtAddress.Text))
            {
                try
                {
                    byte[] img;
                    if (pbImage.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                        img = ms.ToArray();
                        DataProvider.account.photo = img;
                    }
                    else
                    {
                        img = null;
                    }

                    if (DataProvider.account.UpdateMyAccount(txtFName.Text, txtLName.Text, dtpBirth.Value, gender, txtPhone.Text, txtAddress.Text, img))
                    {
                        MessageBox.Show("Update successfully!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
        
}

