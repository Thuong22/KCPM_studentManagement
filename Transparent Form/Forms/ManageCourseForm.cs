using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparent_Form
{
    public partial class ManageCourseForm : Form
    {
        Course course = new Course();

        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            dtgvCourse.AutoGenerateColumns = false;
            dtgvCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnClear.Enabled = false;
            this.ActiveControl = txtSearch;

            LoadCourseList();
            dtgvCourse.ClearSelection();
        }

        private void LoadCourseList()
        {
            dtgvCourse.DataSource = course.GetCourseList("SELECT * FROM `course`");
        }

        private void dtgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgvCourse.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dtgvCourse.CurrentRow.Cells[1].Value.ToString();
            numHour.Text = dtgvCourse.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dtgvCourse.CurrentRow.Cells[3].Value.ToString();
            btnClear.Enabled = true;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            numHour.Value = 0;
            txtDescription.Clear();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
            this.ActiveControl = txtSearch;
            dtgvCourse.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyField(txtName.Text, numHour.Text))
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string name = txtName.Text;
                int chr = CheckValidHour(numHour.Text);
                if (chr == 0)
                {
                    MessageBox.Show("Study duration must be a positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string desc = txtDescription.Text;
                try
                {
                    course.InsertCourse(name, chr, desc);
                    LoadCourseList();
                    btnClear.PerformClick();
                    MessageBox.Show("Add new course successfully!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyField(txtName.Text, numHour.Text))
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                string name = txtName.Text;
                int chr = CheckValidHour(numHour.Text);
                if (chr == 0 || chr == -1)
                {
                    MessageBox.Show("Study duration must be a positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string desc = txtDescription.Text;

                try
                {
                    course.UpdateCourse(id, name, chr, desc);
                    LoadCourseList();
                    btnClear.PerformClick();
                    MessageBox.Show("Update course data successfully!", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you eant to remove this course?", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);
                    course.DeletCourse(id);
                    LoadCourseList();
                    btnClear.PerformClick();
                    MessageBox.Show("Remove course successfully!", "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var txt = (sender as TextBox);
            if (txt.Text.Length == 0)
                LoadCourseList();
            else
                dtgvCourse.DataSource = course.GetCourseList($"SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE '%{txtSearch.Text}%'");
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
        public bool CheckEmptyField(string cName, string cHour)
        {
            if (string.IsNullOrWhiteSpace(cName) || string.IsNullOrWhiteSpace(cHour))
                return false;
            return true;
        }

        public int CheckValidHour(string cHour)
        {
            try
            {
                int chr = Convert.ToInt32(cHour);
                if (chr <= 0)
                    return 0;
                return chr;
            }
            catch
            {
                return 0;
            }
        }
        #endregion  
    }
}
