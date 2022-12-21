using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparent_Form.Forms
{
    public partial class AllCoursesForm : Form
    {
        Course course = new Course();
        Score score = new Score();
        int studentId = 5;

        public AllCoursesForm()
        {
            InitializeComponent();
        }

        private void AllCoursesForm_Load(object sender, EventArgs e)
        {
            dtgvCourse.AutoGenerateColumns = false;
            dtgvCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            txtHour.Text = dtgvCourse.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dtgvCourse.CurrentRow.Cells[3].Value.ToString();
            btnClear.Enabled = true;
            btnJoin.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtHour.Clear();
            txtDescription.Clear();
            btnClear.Enabled = false;
            btnJoin.Enabled = false;
            dtgvCourse.ClearSelection();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (!CheckJoin(studentId, int.Parse(txtId.Text)))
            {
                MessageBox.Show("You have already joined this course!", "Add Student To Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                score.InsertScore(studentId, int.Parse(txtId.Text));
                MessageBox.Show("You join this course successfully!", "Join Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
