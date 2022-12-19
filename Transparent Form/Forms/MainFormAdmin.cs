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
    public partial class MainFormAdmin : Form
    {
        AccountClass student = new AccountClass();
        CourseClass course = new CourseClass();
        bool isLogout = false;
        public MainFormAdmin()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panel_accountSubmenu.Visible = false;
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_user.Text = AccountClass.account.username;

            studentCount();
            comboBox_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName";
        }

        private void studentCount()
        {
            //Display the values
            label_totalStd.Text = "Total Students : " + student.totalStudent();
            label_maleStd.Text = "Male : " + student.maleStudent();
            label_femaleStd.Text = "Female : " + student.femaleStudent();

        }

        private void hideSubmenu()
        {
            if (panel_accountSubmenu.Visible == true)
                panel_accountSubmenu.Visible = false;
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_account_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_accountSubmenu);
        }
        #region AccountSubmenu
        private void button_manageAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageAccountForm());
            hideSubmenu();
        }

        private void button_myAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new MyAccountForm());
            hideSubmenu();
        }

        #endregion AccountSubmenu

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }
        #region StdSubmenu
        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            hideSubmenu();
        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            hideSubmenu();
        }

        #endregion StdSubmenu
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }
        #region CourseSubmenu
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            hideSubmenu();
        }

        private void button_studentCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            hideSubmenu();
        }
        #endregion CourseSubmenu

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }
        #region ScoreSubmenu
        private void button_manageScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageScoreForm());       
            hideSubmenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
            hideSubmenu();
        }


        #endregion ScoreSubmenu

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentCount();
            label_user.Text = AccountClass.account.username;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = comboBox_course.GetItemText(comboBox_course.SelectedItem);
            label_cmale.Text = "Male : " + student.getOneValueFromTable("SELECT COUNT(*) FROM account INNER JOIN score INNER JOIN course ON account.AccId=score.StudentId AND score.CourseId=course.CourseId WHERE course.CourseName='" + comboBox_course.GetItemText(comboBox_course.SelectedItem) +"' AND `Gender`= 'Male'");
            label_cfemale.Text = "Female : " + student.getOneValueFromTable("SELECT COUNT(*) FROM account INNER JOIN score INNER JOIN course ON account.AccId=score.StudentId AND score.CourseId=course.CourseId WHERE course.CourseName='" + comboBox_course.GetItemText(comboBox_course.SelectedItem) + "' AND `Gender`= 'Female'");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
                Application.Exit();
        }

    }
}