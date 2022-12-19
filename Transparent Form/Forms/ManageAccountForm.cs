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


namespace Transparent_Form
{
    public partial class ManageAccountForm : Form
    {
        private AccountClass account = new AccountClass();
        public ManageAccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            comboBox_typeSearch.Items.Add("All");
            comboBox_typeSearch.Items.Add("Admin");
            comboBox_typeSearch.Items.Add("Student");
            comboBox_typeSearch.SelectedIndex = 0;
                       
            comboBox_type.Items.Add("Admin");
            comboBox_type.Items.Add("Student");
            comboBox_type.SelectedIndex = -1;

            button_delete.Enabled = false;
            button_update.Enabled = false;
            dtpBirth.CustomFormat = "dd / MM / yyyy  -  dddd";
            showTable();
        }

        public void showTable()
        {
            DataGridView_account.DataSource = account.getList(new MySqlCommand("SELECT AccId, Username, Type,AccFirstName, AccLastName, Birthdate, Gender, Phone, Address, Photo FROM `account` "));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_account.Columns[9];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
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

        private void DataGridView_account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.ReadOnly = true;
            buttonEnable();
            comboBox_type.Enabled = false;

            textBox_id.Text = DataGridView_account.CurrentRow.Cells[0].Value.ToString();
            textBox_Username.Text = DataGridView_account.CurrentRow.Cells[1].Value.ToString();
            if (DataGridView_account.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                comboBox_type.SelectedIndex = 0;
            }
            else
            {
                comboBox_type.SelectedIndex = 1;
            }
            textBox_Fname.Text = DataGridView_account.CurrentRow.Cells[3].Value.ToString();
            textBox_Lname.Text = DataGridView_account.CurrentRow.Cells[4].Value.ToString();
            dtpBirth.Value = (DateTime)DataGridView_account.CurrentRow.Cells[5].Value;
            if (DataGridView_account.CurrentRow.Cells[6].Value.ToString() == "Male")
                radioButton_male.Checked = true;

            textBox_phone.Text = DataGridView_account.CurrentRow.Cells[7].Value.ToString();
            textBox_address.Text = DataGridView_account.CurrentRow.Cells[8].Value.ToString();

            byte[] img;
            try
            {
                img = (byte[])DataGridView_account.CurrentRow.Cells[9].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox_account.Image = Image.FromStream(ms);
            }
            catch
            {
                img = null;
                pictureBox_account.Image = null;
            }
        }

        private void buttonEnable()
        {
            if (textBox_id.ReadOnly == true)
            {
                button_add.Enabled = false;
                button_update.Enabled = true;
                button_delete.Enabled = true;
            }
            else
            {
                button_add.Enabled = true;
                button_update.Enabled = false;
                button_delete.Enabled = false;
            }
        }

        
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Username.Clear();
            comboBox_type.SelectedIndex = -1;
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dtpBirth.Value = DateTime.Now;
            pictureBox_account.Image = null;

            comboBox_type.Enabled = true;
            textBox_id.ReadOnly = false;
            buttonEnable();
        }

        
        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_account.Image = Image.FromFile(opf.FileName);
        }

        
        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT AccId, Username, Type, AccFirstName, AccLastName, Birthdate, Gender, Phone, Address, Photo FROM `account`";
            if (comboBox_typeSearch.Text != "All")           
            {
                if (comboBox_typeSearch.Text == "Admin")
                    selectQuery += "WHERE `Type`= 1";
                else
                    selectQuery += "WHERE `Type`= 2";
            }

            DataGridView_account.DataSource = account.getList(new MySqlCommand(selectQuery));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();            
            imageColumn = (DataGridViewImageColumn)DataGridView_account.Columns[9];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        
        private void button_add_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            int type = comboBox_type.SelectedIndex + 1;
            string stype = "";
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dtpBirth.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";

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
                    if (pictureBox_account.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox_account.Image.Save(ms, pictureBox_account.Image.RawFormat);
                        img = ms.ToArray();
                    }
                    else
                    {
                        img = null;
                    }

                    if (account.insertAccount(username, type, fname, lname, bdate, gender, phone, address, img))
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
                        button_clear.PerformClick();
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

        
        private void button_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            string usr = textBox_Username.Text;
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dtpBirth.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";

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
                    if (pictureBox_account.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox_account.Image.Save(ms, pictureBox_account.Image.RawFormat);
                        img = ms.ToArray();
                    }
                    else
                    {
                        img = null;
                    }

                    if (account.updateAccount(id, usr, fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("Update account data successfully!", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
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

        private void textBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            if (MessageBox.Show("Are you sure you want to remove this account", "Remove Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (account.deleteAccount(id))
                {
                    showTable();
                    MessageBox.Show("Remove account successfully!", "Remove account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
            }
        }
    }
}
