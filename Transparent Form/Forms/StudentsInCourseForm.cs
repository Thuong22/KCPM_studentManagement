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
    public partial class StudentInCourseForm : Form
    {
        Course course = new Course();
        Score score = new Score();
        public StudentInCourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            dtgvStudentCourse.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgvStudentCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cbbCourse.DataSource = course.GetCourseList("SELECT * FROM `course`");
            cbbCourse.DisplayMember = "CourseName";
            cbbCourse.ValueMember = "CourseId";
            cbbCourse.SelectedIndex = -1;

            cbbStudent.DataSource = course.GetCourseList("SELECT * FROM `student`");
            cbbStudent.DisplayMember = "StdFirstName";
            cbbStudent.ValueMember = "StdId";
            cbbStudent.SelectedIndex = -1;

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            LoadStudentsOfCourseList();
            this.ActiveControl = txtSearch;
        }

        private void LoadStudentsOfCourseList()
        {
            dtgvStudentCourse.DataSource = course.GetCourseList(
                @"  SELECT score.StudentId,student.StdFirstName,student.StdLastName,score.CourseId,course.CourseName 
                    FROM score INNER JOIN student INNER JOIN course
                    WHERE score.StudentId=student.StdId AND score.CourseId=course.CourseId
                    ORDER BY score.StudentId, score.CourseId");
            dtgvStudentCourse.ClearSelection();
        }

        private void dtgvStudentCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentId.Text = dtgvStudentCourse.CurrentRow.Cells[0].Value.ToString();
            txtStudentName.Text = dtgvStudentCourse.CurrentRow.Cells[1].Value.ToString() + " " + dtgvStudentCourse.CurrentRow.Cells[2].Value.ToString();
            txtCourseId.Text = dtgvStudentCourse.CurrentRow.Cells[3].Value.ToString();
            txtCourseName.Text = dtgvStudentCourse.CurrentRow.Cells[4].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbStudent.SelectedIndex == -1 || cbbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both student and course!", "Add Student To Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stdID = Convert.ToInt32(cbbStudent.SelectedValue);
            int courID = Convert.ToInt32(cbbCourse.SelectedValue);
            if (!CheckJoin(stdID, courID))
            {
                MessageBox.Show("This student is already joined this course!", "Add Student To Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                score.InsertScore(stdID, courID);
                MessageBox.Show("Add student to course successfully!", "Add Student To Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentsOfCourseList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int stdID = Convert.ToInt32(txtStudentId.Text);
            int courID = Convert.ToInt32(txtCourseId.Text);
            if (MessageBox.Show("Are you sure you want to remove this?", "Remove Student From Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    score.DeleteScore(stdID, courID);
                    MessageBox.Show("Remove student form course successfully!", "Remove Student From Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCourseId.Text = "";
                    txtCourseName.Text = "";
                    txtStudentId.Text = "";
                    txtStudentName.Text = "";
                    LoadStudentsOfCourseList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void cbbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void EnableButton()
        {
            if (cbbStudent.SelectedIndex != -1 || cbbStudent.SelectedIndex != -1)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var txt = (sender as TextBox);
            if (txt.Text.Length == 0)
                LoadStudentsOfCourseList();
            else
                dtgvStudentCourse.DataSource = course.GetCourseList("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseId, course.CourseName " +
               "FROM score INNER JOIN student INNER JOIN course " +
               "ON score.StudentId=student.StdId AND score.CourseId=course.CourseId " +
               $"WHERE CONCAT(course.CourseName, student.StdFirstName, student.StdLastName)LIKE '%{txtSearch.Text}%'");
        }

        #region Validation
        private bool CheckJoin(int stdId, int courId)
        {
            DataTable join = course.GetCourseList(
                "SELECT * FROM score WHERE score.StudentId=" + stdId + " AND score.CourseId=" + courId);
            int count = join.Rows.Count;
            if (count != 0)
                return false;
            return true;
        }
        #endregion
    }
}
