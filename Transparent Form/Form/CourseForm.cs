using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Transparent_Form
{
    public partial class CourseForm : Form
    {
        StudentClass student = new StudentClass();
        CourseClass course = new CourseClass();
        ScoreClass score = new ScoreClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            comboBox_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseId";
            comboBox_course.SelectedIndex = -1;

            comboBox_student.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `student`"));
            comboBox_student.DisplayMember = "StdFirstName";
            comboBox_student.ValueMember = "StdId";
            comboBox_student.SelectedIndex = -1;

            button_delete.Enabled = false;

            showData();
        }

        private void showData()
        {
            DataGridView_studentCourse.DataSource = course.getCourse(new MySqlCommand(
                "SELECT score.StudentId,student.StdFirstName,student.StdLastName,score.CourseId,course.CourseName " +
                "FROM score INNER JOIN student INNER JOIN course " +
                "WHERE score.StudentId=student.StdId AND score.CourseId=course.CourseId"));
        }

        private void DataGridView_studentCourse_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_StdId.Text = DataGridView_studentCourse.CurrentRow.Cells[0].Value.ToString();
                textBox_StdName.Text = DataGridView_studentCourse.CurrentRow.Cells[1].Value.ToString() + " " + DataGridView_studentCourse.CurrentRow.Cells[2].Value.ToString();
                textBox_courId.Text = DataGridView_studentCourse.CurrentRow.Cells[3].Value.ToString();
                textBox_courName.Text = DataGridView_studentCourse.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        #region Validation
        private bool CheckJoin(int stdId, int courId)
        {
            DataTable join = course.getCourse(new MySqlCommand(
                "SELECT * " +
                "FROM score " +
                "WHERE score.StudentId=" + stdId + " AND score.CourseId=" + courId));
            int count = join.Rows.Count;
            if (count != 0)
                return false;
            return true;
        }    
        #endregion

        private void button_add_Click(object sender, EventArgs e)
        {
            if (comboBox_student.SelectedIndex==-1||comboBox_course.SelectedIndex==-1)
            {
                MessageBox.Show("Please select student and course!", "Add Student To Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            int stdID = Convert.ToInt32(comboBox_student.SelectedValue);
            int courID = Convert.ToInt32(comboBox_course.SelectedValue);
            if (!CheckJoin(stdID, courID))
            {
                MessageBox.Show("This student is already joined this course!", "Add Student To Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                score.insertScore(stdID, courID);
                MessageBox.Show("Add student to course successfully!", "Add Student To Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int stdID = Convert.ToInt32(textBox_StdId.Text);
            int courID = Convert.ToInt32(textBox_courId.Text);
            if (MessageBox.Show("Are you sure you want to remove this?", "Remove Student From Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    score.deleteScore(stdID, courID);
                    MessageBox.Show("Remove student form course successfully!", "Remove Student From Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_courId.Text = "";
                    textBox_courName.Text = "";
                    textBox_StdId.Text = "";
                    textBox_StdName.Text = "";
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_studentCourse.DataSource = score.getList(new MySqlCommand(
                "SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseId, course.CourseName " +
                "FROM score INNER JOIN student INNER JOIN course " +
                "ON score.StudentId=student.StdId AND score.CourseId=course.CourseId " +
                "WHERE CONCAT(course.CourseName, student.StdFirstName, student.StdLastName)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_StdId.Text == "") 
            {
                button_delete.Enabled = false;
            }
            else
            {
                button_delete.Enabled = true;
            }
        }
    }
}
