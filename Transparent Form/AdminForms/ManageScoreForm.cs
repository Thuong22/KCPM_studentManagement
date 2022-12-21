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
    public partial class ManageScoreForm : Form
    {
        Score score = new Score();
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            this.ActiveControl = txtSearch;
            dtgvScore.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            LoadScore();
            dtgvScore.ClearSelection();
        }
        public void LoadScore()
        {
            dtgvScore.DataSource = score.GetScoreList(
                "SELECT score.StudentId, account.AccFirstName, account.AccLastName, course.CourseId, course.CourseName, score.Score, score.Description " +
                "FROM account INNER JOIN score INNER JOIN course " +
                "ON score.StudentId = account.AccId AND score.CourseId=course.CourseId");
        }

        private void dtgvScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgvScore.CurrentRow.Cells[0].Value.ToString();
            txtStudentName.Text = dtgvScore.CurrentRow.Cells[1].Value.ToString() + " " + dtgvScore.CurrentRow.Cells[2].Value.ToString();
            txtCourseName.Text = dtgvScore.CurrentRow.Cells[4].Value.ToString();
            txtScore.Text = dtgvScore.CurrentRow.Cells[5].Value.ToString();
            txtComment.Text = dtgvScore.CurrentRow.Cells[6].Value.ToString() == null ? "" : dtgvScore.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = txtStudentName.Text = txtCourseName.Text = txtScore.Text = txtComment.Text = "";
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(txtId.Text);
            int courseId = Convert.ToInt32(dtgvScore.CurrentRow.Cells[3].Value.ToString());
            Nullable<double> scor = CheckValidScore(txtScore.Text);
            
            if (scor == -1)
            {
                MessageBox.Show("Score must be in range 0 - 100!", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (scor == -2)
            {
                MessageBox.Show("Input data of score is incorrect format!", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cmt = txtComment.Text;
            try
            {
                score.UpdateScore(studentId, courseId, scor, cmt);
                MessageBox.Show("Update score successfully", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadScore();
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
                LoadScore();
            else
            {
                dtgvScore.DataSource = score.GetScoreList(
                $@"SELECT score.StudentId, account.AccFirstName, account.AccLastName, course.CourseId, course.CourseName, score.Score, score.Description
                FROM account INNER JOIN score INNER JOIN course 
                ON score.StudentId = account.AccId AND score.CourseId = course.CourseId
                WHERE CONCAT(account.AccFirstName, account.AccLastName, course.CourseName)LIKE '%" + txtSearch.Text + "%'");
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
                btnUpdate.Enabled = false;
            else
                btnUpdate.Enabled = true;
        }

        #region Validation
        public Nullable<double> CheckValidScore(string tbxScore)
        {
            // -1: out of range
            // -2: incorrect format
            // null: empty/null
            // scor: valid
            if (String.IsNullOrEmpty(tbxScore))
                return null;

            double scor;

            try
            {
                scor = Math.Round(Convert.ToDouble(tbxScore));
                if (scor < 0 || scor > 100)
                {
                    return -1;
                }
            }
            catch
            {
                return -2;
            }
            return scor;
        }
        #endregion
    }
}
