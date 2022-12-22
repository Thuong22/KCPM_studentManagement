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

namespace Transparent_Form.AdminForms
{
    public partial class ManageAccountForm : Form
    {
        private Account account = new Account();
        public ManageAccountForm()
        {
            InitializeComponent();
        }

        private void ManageAccountForm_Load(object sender, EventArgs e)
        {
            cbbSearch.Items.Add("All");
            cbbSearch.Items.Add("Admin");
            cbbSearch.Items.Add("Student");
            cbbSearch.SelectedIndex = 0;          

            cbbType.Items.Add("Admin");
            cbbType.Items.Add("Student");
            cbbType.SelectedIndex = -1;           

            BtnEnable();
            dtpBirth.CustomFormat = "dd / MM / yyyy  -  dddd";
            showTable();
        }
      
        public void showTable()
        {
            dtgvAccount.DataSource = account.GetStudentList("SELECT AccId, Username, Type,AccFirstName, AccLastName, Birthdate, Gender, Phone, Address, Photo FROM `account` ");
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dtgvAccount.Columns[9];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbType.Enabled = false;
            BtnEnable();
            txtId.Text = dtgvAccount.CurrentRow.Cells[0].Value.ToString();
            txtUsername.Text = dtgvAccount.CurrentRow.Cells[1].Value.ToString();
            if (dtgvAccount.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                cbbType.SelectedIndex = 0;
            }
            else
            {
                cbbType.SelectedIndex = 1;
            }
            txtFName.Text = dtgvAccount.CurrentRow.Cells[3].Value.ToString();
            txtLName.Text = dtgvAccount.CurrentRow.Cells[4].Value.ToString();
            dtpBirth.Value = (DateTime)dtgvAccount.CurrentRow.Cells[5].Value;
            if (dtgvAccount.CurrentRow.Cells[6].Value.ToString() == "Male")
                rbMale.Checked = true;

            txtPhone.Text = dtgvAccount.CurrentRow.Cells[7].Value.ToString();
            txtAddress.Text = dtgvAccount.CurrentRow.Cells[8].Value.ToString();

            byte[] img;
            try
            {
                img = (byte[])dtgvAccount.CurrentRow.Cells[9].Value;
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

       
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pbImage.Image = Image.FromFile(opf.FileName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtUsername.Clear();
            cbbType.SelectedIndex = -1;
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            rbMale.Checked = true;
            dtpBirth.Value = DateTime.Now;
            pbImage.Image = null;

            cbbType.Enabled = true;
            txtId.ReadOnly = false;
            BtnEnable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                string username = txtUsername.Text;
                int type = cbbType.SelectedIndex + 1;
                string stype = "";
                string fname = txtFName.Text;
                string lname = txtLName.Text;
                DateTime bdate = dtpBirth.Value;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                string gender = rbMale.Checked ? "Male" : "Female";

                if (!CheckBirthday(bdate))
                {
                    MessageBox.Show("Age of account must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CheckEmptyField(username, lname, fname, phone, address))
                {
                    try
                    {
                        byte[] img;
                        if (pbImage.Image != null)
                        {
                            MemoryStream ms = new MemoryStream();
                            pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                            img = ms.ToArray();
                        }
                        else
                        {
                            img = null;
                        }

                        if (account.InsertAccount(username, type, fname, lname, bdate, gender, phone, address, img))
                        {
                            showTable();
                            if (account.type == 1)
                            {
                                stype = "Admin";
                            }
                            else
                            {
                                stype = "Student";
                            }
                            MessageBox.Show("Add new account successfully!" + $" \n New Account: \n Username: {account.username} \n Password: {account.password} \n Type: {stype}", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
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
                    MessageBox.Show("Please fill in all fields", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
        }    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string usr = txtUsername.Text;
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            DateTime bdate = dtpBirth.Value;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = rbMale.Checked ? "Male" : "Female";

            if (!CheckBirthday(bdate))
            {
                MessageBox.Show("Age of student must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckEmptyField(usr, lname, fname, phone, address))
            {
                try
                {
                    byte[] img;
                    if (pbImage.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                        img = ms.ToArray();
                    }
                    else
                    {
                        img = null;
                    }

                    if (account.UpdateAccount(id, usr, fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("Update account data successfully!", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear.PerformClick();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            if (MessageBox.Show("Are you sure you want to remove this account", "Remove Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (account.DeleteAccount(id))
                {
                    showTable();
                    MessageBox.Show("Remove account successfully!", "Remove account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();
                }
            }
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuery = "SELECT AccId, Username, Type, AccFirstName, AccLastName, Birthdate, Gender, Phone, Address, Photo FROM `account`";
            if (cbbSearch.Text != "All")
            {
                if (cbbSearch.Text == "Admin")
                    selectQuery += "WHERE `Type`= 1";
                else
                    selectQuery += "WHERE `Type`= 2";
            }

            dtgvAccount.DataSource = account.GetStudentList(selectQuery);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dtgvAccount.Columns[9];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))               
            {
                e.Handled = true;
            }
        }

        private void BtnEnable()
        {
            if (txtId.Text != "")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            BtnEnable();
        }
    }
}
