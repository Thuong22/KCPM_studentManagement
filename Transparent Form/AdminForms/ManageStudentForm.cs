using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Transparent_Form
{
    public partial class ManageStudentForm : Form
    {
        Account student = new Account();
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            //System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
            //System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            //System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
            //dtpBirth.Value.GetDateTimeFormats(culture);

            txtPhone.MaxLength = 10;

            dtgvStudent.AutoGenerateColumns = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnClear.Enabled = false;
            this.ActiveControl = txtSearch;
            dtpBirth.CustomFormat = "dd / MM / yyyy  -  dddd";

            LoadStudentList();
            dtgvStudent.ClearSelection();
        }

        public void LoadStudentList()
        {
            dtgvStudent.DataSource = student.GetStudentList("SELECT AccId, AccFirstName, AccLastName, Birthdate, Gender, Phone, Address, Photo FROM `account` WHERE Type = 2");
            dtgvStudent.Columns[7].GetType();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dtgvStudent.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void dtgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgvStudent.CurrentRow.Cells[0].Value.ToString();
            txtFName.Text = dtgvStudent.CurrentRow.Cells[1].Value.ToString();
            txtLName.Text = dtgvStudent.CurrentRow.Cells[2].Value.ToString();
            dtpBirth.Value = (DateTime)dtgvStudent.CurrentRow.Cells[3].Value;
            if (dtgvStudent.CurrentRow.Cells[4].Value.ToString() == "Male")
                rbMale.Checked = true;
            txtPhone.Text = dtgvStudent.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dtgvStudent.CurrentRow.Cells[6].Value.ToString();

            byte[] img;
            try
            {
                img = (byte[])dtgvStudent.CurrentRow.Cells[7].Value;
                MemoryStream ms = new MemoryStream(img);
                pbImage.Image = Image.FromStream(ms);
            }
            catch
            {
                img = null;
                pbImage.Image = null;
            }

            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            txtId.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            rbMale.Checked = true;
            dtpBirth.Value = DateTime.Now;
            pbImage.Image = null;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
            dtgvStudent.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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

            if (CheckEmptyField(lname, fname, phone, address))
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
                        img = null;

                    if (student.InsertStudent(fname, lname, bdate, gender, phone, address, img))
                    {
                        LoadStudentList();
                        MessageBox.Show("Add new student successfully!" + $" \n New Student Account: \n Username: {student.username} \n Password: {student.password}", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please fill in all fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
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

            if (CheckEmptyField(lname, fname, phone, address))
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

                    if (student.UpdateStudent(id, fname, lname, bdate, gender, phone, address, img))
                    {
                        LoadStudentList();
                        MessageBox.Show("Update student data successfully!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please fill in all fields", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            if (MessageBox.Show("Are you sure you want to remove this student?", "Remove Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.DeleteAccount(id))
                {
                    LoadStudentList();
                    MessageBox.Show("Remove student successfully!", "Remove student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var t = new Thread((ThreadStart)(() =>
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

                if (opf.ShowDialog() == DialogResult.OK)
                    pbImage.Image = Image.FromFile(opf.FileName);
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var txt = (sender as TextBox);
            if (txt.Text.Length == 0)
                LoadStudentList();
            else
            {
                dtgvStudent.DataSource = student.SearchStudent(txtSearch.Text);
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dtgvStudent.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == null)
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        #region Validation
        public bool CheckEmptyField(string lname, string fname, string phone, string address)
        {
            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
                return false;
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
