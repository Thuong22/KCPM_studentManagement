using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Transparent_Form.Forms
{
    public partial class MyCoursesForm : Form
    {
        Course course = new Course();
        int studentId = 5;

        public MyCoursesForm()
        {
            InitializeComponent();
        }

        private void MyCoursesForm_Load(object sender, EventArgs e)
        {
            dtgvCourse.AutoGenerateColumns = false;
            dtgvCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.ActiveControl = txtSearch;
            LoadCourseList();
            dtgvCourse.ClearSelection();
        }

        private void LoadCourseList()
        {
            dtgvCourse.DataSource = course.GetCourseList($@"SELECT score.CourseId, course.CourseName, course.CourseHour, course.Description, score.Score 
            FROM score INNER JOIN course ON score.StudentId={studentId} AND score.CourseId=course.CourseId;");

            lbTotal.Text = dtgvCourse.Rows.Count.ToString();
        }

        private void dtgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgvCourse.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dtgvCourse.CurrentRow.Cells[1].Value.ToString() + " " + dtgvCourse.CurrentRow.Cells[2].Value.ToString();
            numHour.Text = dtgvCourse.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dtgvCourse.CurrentRow.Cells[3].Value.ToString();
            txtScore.Text = dtgvCourse.CurrentRow.Cells[4].Value.ToString();
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            numHour.Value = 0;
            txtDescription.Clear();
            txtScore.Clear();
            btnClear.Enabled = false;
            dtgvCourse.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var txt = (sender as TextBox);
            if (txt.Text.Length == 0)
                LoadCourseList();
            else
                dtgvCourse.DataSource = course.GetCourseList($@"SELECT score.CourseId, course.CourseName, course.CourseHour, course.Description, score.Score 
                FROM score INNER JOIN course ON score.CourseId = course.CourseId AND score.StudentId={studentId} 
                WHERE CONCAT(score.CourseId, course.CourseName, score.Score)LIKE '%{txtSearch.Text}%';");
        }
    }
}
