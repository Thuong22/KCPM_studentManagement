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
        CourseClass course = new CourseClass();
        ScoreClass score = new ScoreClass();
        public ManageScoreForm()
        {
            InitializeComponent();
            button_update.Enabled = false;
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            showScore();
        }
        public void showScore()
        {
            DataGridView_score.DataSource = score.getList(new MySqlCommand(
                "SELECT score.StudentId, account.AccFirstName, account.AccLastName, course.CourseId, course.CourseName, score.Score, score.Description " +
                "FROM account INNER JOIN score INNER JOIN course " +
                "ON score.StudentId = account.AccId AND score.CourseId=course.CourseId"));
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_stdId.Text = textBox_stdName.Text = textBox_courName.Text = textBox_score.Text = textBox_description.Text = "";
            button_update.Enabled = false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_score.DataSource = score.getList(new MySqlCommand(
                "SELECT score.StudentId, account.AccFirstName, account.AccLastName, course.CourseId, course.CourseName, score.Score, score.Description " +
                "FROM account INNER JOIN score INNER JOIN course " +
                "ON score.StudentId = account.AccId AND score.CourseId = course.CourseId " +
                "WHERE CONCAT(account.AccFirstName, account.AccLastName, course.CourseName)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
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

        private void button_update_Click(object sender, EventArgs e)
        {
            int stdId = Convert.ToInt32(textBox_stdId.Text);
            int courid = Convert.ToInt32(DataGridView_score.CurrentRow.Cells[3].Value.ToString());
            Nullable<double> scor = CheckValidScore(textBox_score.Text);
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

            string desc = textBox_description.Text;

            try
            {
                score.updateScore(stdId, courid, scor, desc);
                MessageBox.Show("Update score successfully", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showScore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView_score_Click(object sender, DataGridViewCellEventArgs e)
        {
            textBox_stdId.Text = DataGridView_score.CurrentRow.Cells[0].Value.ToString();
            textBox_stdName.Text = DataGridView_score.CurrentRow.Cells[1].Value.ToString() + " " + DataGridView_score.CurrentRow.Cells[2].Value.ToString();
            textBox_courName.Text = DataGridView_score.CurrentRow.Cells[4].Value.ToString();
            textBox_score.Text = DataGridView_score.CurrentRow.Cells[5].Value.ToString();
            textBox_description.Text = DataGridView_score.CurrentRow.Cells[6].Value.ToString() == null ? "" : DataGridView_score.CurrentRow.Cells[6].Value.ToString();
        }

        private void textBox_stdId_TextChanged(object sender, EventArgs e)
        {
            if (textBox_stdId.Text == "")
                button_update.Enabled = false;
            else
                button_update.Enabled = true;
        }
    }
}
