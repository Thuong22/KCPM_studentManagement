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

namespace Transparent_Form
{
    public partial class MyAccountForm : Form
    {
        public MyAccountForm()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
            comboBox_type.Items.Add("Admin");
            comboBox_type.Items.Add("Student");
            comboBox_type.SelectedIndex = -1;
            panel_changePass.SendToBack();
        }

        private void MyAccountForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            label1_username.Text = AccountClass.account.username + ",";

            textBox_id.Text = AccountClass.account.accId.ToString();
            textBox_Username.Text = AccountClass.account.username;
            textBox_password.Text = AccountClass.account.password;
            comboBox_type.SelectedIndex = AccountClass.account.type - 1;

            textBox_Fname.Text = AccountClass.account.accFirstName;
            textBox_Lname.Text = AccountClass.account.accLastName;
            dtpBirth.Value = AccountClass.account.birthdate;
            if (AccountClass.account.gender == "Male")
                radioButton_male.Checked = true;
            textBox_phone.Text = AccountClass.account.phone;
            textBox_address.Text = AccountClass.account.address;
            byte[] img;
            try
            {
                img = (byte[])AccountClass.account.photo;
                MemoryStream ms = new MemoryStream(img);
                pictureBox_account.Image = Image.FromStream(ms);
            }
            catch
            {
                img = null;
                pictureBox_account.Image = null;
            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {            
            AccountClass.account.username = textBox_Username.Text;           
            AccountClass.account.type = comboBox_type.SelectedIndex + 1;
            AccountClass.account.accFirstName = textBox_Fname.Text;
            AccountClass.account.accLastName = textBox_Lname.Text;
            AccountClass.account.birthdate = dtpBirth.Value;
            AccountClass.account.phone = textBox_phone.Text;
            AccountClass.account.address = textBox_address.Text;
            AccountClass.account.gender = radioButton_male.Checked ? "Male" : "Female";

            if (!CheckBirthday(dtpBirth.Value))
            {
                MessageBox.Show("Age of student must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckEmptyField(textBox_Username.Text, textBox_Fname.Text, textBox_Lname.Text, textBox_phone.Text, textBox_address.Text))
            {
                try
                {
                    byte[] img;
                    if (pictureBox_account.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox_account.Image.Save(ms, pictureBox_account.Image.RawFormat);
                        img = ms.ToArray();
                        AccountClass.account.photo = img;
                    }
                    else
                    {
                        img = null;
                    }

                    if (AccountClass.account.updateMyAccount())
                    {
                        MessageBox.Show("Update successfully!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();
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

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_account.Image = Image.FromFile(opf.FileName);
        }

        #region Validation
        public bool CheckEmptyField(string username, string lname, string fname, string phone, string address)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
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

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            panel_changePass.BringToFront();
        }

        private void button_savePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_currentPass.Text) || string.IsNullOrWhiteSpace(textBox_newPass.Text) || string.IsNullOrWhiteSpace(textBox_checkNewPass.Text) )
            {
                MessageBox.Show("Please fill in all fields", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (AccountClass.account.password != textBox_currentPass.Text)
            {
                MessageBox.Show("Current password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_newPass.Text != textBox_checkNewPass.Text)
            {
                MessageBox.Show("The Confirm New Password confirmation does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AccountClass.account.updatePassword(textBox_newPass.Text))
            {
                MessageBox.Show("Update successfully!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_password.Text = AccountClass.account.password;
                textBox_currentPass.Clear();
                textBox_newPass.Clear();
                textBox_checkNewPass.Clear();
                panel_changePass.SendToBack();
            }
               
        }

       
        private void btn_return_Click(object sender, EventArgs e)
        {
            textBox_currentPass.Clear();
            textBox_newPass.Clear();
            textBox_checkNewPass.Clear();
            panel_changePass.SendToBack();
        }
    }
}
