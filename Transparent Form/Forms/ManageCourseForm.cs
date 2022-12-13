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
            button_delete.Enabled = false;
            button_update.Enabled = false;
            showData();
        }

        private void showData()
        {
            DataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void DataGridView_course_Click(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = DataGridView_course.CurrentRow.Cells[0].Value.ToString();
            textBox_cName.Text = DataGridView_course.CurrentRow.Cells[1].Value.ToString();
            textBox_cHour.Text = DataGridView_course.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = DataGridView_course.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_cName.Clear();
            textBox_cHour.Clear();
            textBox_description.Clear();
            button_add.Enabled = true;
            button_delete.Enabled = false;
            button_update.Enabled = false;
        }

        #region Validation
        public bool CheckEmptyField(string cName, string cHour)
        {
            if (string.IsNullOrWhiteSpace(cName) || string.IsNullOrWhiteSpace(cHour)) 
            {
                return false;
            }
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

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyField(textBox_cName.Text, textBox_cHour.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cName = textBox_cName.Text;
                int chr = CheckValidHour(textBox_cHour.Text);
                if (chr == 0)
                {
                    MessageBox.Show("Study duration must be a positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string desc = textBox_description.Text;

                try
                {
                    course.insertCourse(cName, chr, desc);
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("Add new course successfully!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyField(textBox_cName.Text, textBox_cHour.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                int id = Convert.ToInt32(textBox_id.Text);
                string cName = textBox_cName.Text;
                int chr = CheckValidHour(textBox_cHour.Text);
                if (chr == 0 || chr == -1)
                {
                    MessageBox.Show("Study duration must be a positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string desc = textBox_description.Text;

                try
                {
                    course.updateCourse(id, cName, chr, desc);
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("Update course data successfully!", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you eant to remove this course?", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    course.deletCourse(id);
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("Remove course successfully!", "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_id.Text == null)
            {
                button_add.Enabled = true;
                button_update.Enabled = false;
                button_delete.Enabled = false;
            }
            else
            {
                button_add.Enabled = false;
                button_update.Enabled = true;
                button_delete.Enabled = true;
            }
        }
    }
}
