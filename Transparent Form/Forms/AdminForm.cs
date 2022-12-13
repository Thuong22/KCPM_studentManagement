using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparent_Form
{
    public partial class AdminForm : Form
    {
        #region DragForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Make rounded form 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        #endregion

        #region Drop Shadow
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        Student student;
        Course course = new Course();
        bool isLogout = false;
        Form activeForm;
        Button curButton;

        public AdminForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlSubStudent.Visible = false;
            pnlSubCourse.Visible = false;
            pnlSubScore.Visible = false;
            student = new Student();

            lbTotalStudent.Text = student.GetNumberOfStudents();
            lbMale.Text = student.GetNumberOfMaleStudents();
            lbFemale.Text = student.GetNumberOfFemaleStudents();

            cbbCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            cbbCourse.DisplayMember = "CourseName";
            cbbCourse.ValueMember = "CourseName";
        }

        private void hideSubmenu()
        {
            if (pnlSubStudent.Visible == true)
                pnlSubStudent.Visible = false;
            if (pnlSubCourse.Visible == true)
                pnlSubCourse.Visible = false;
            if (pnlSubScore.Visible == true)
                pnlSubScore.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;       
            }
            else
                submenu.Visible = false;
        }

        private void EnableButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();

                curButton = (Button)sender;
                curButton.ForeColor = Color.White;
                curButton.BackColor = Color.FromArgb(56, 95, 197);
            }
        }

        private void DisableButton()
        {
            if (curButton != null)
            {
                curButton.BackColor = Color.White;
                curButton.ForeColor = Color.FromArgb(0, 71, 160);
            }
        }

        #region Group of Student button
        private void btnStudent_Click(object sender, EventArgs e)
        {
            EnableButton(sender as Button);
            ShowSubmenu(pnlSubStudent);
        }

        private void btnManageStd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageStudentForm());
        }

        private void btnStudentPrint_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PrintStudent());
        }
        #endregion

        #region Group of Course button
        private void btnCourse_Click(object sender, EventArgs e)
        {
            EnableButton(sender as Button);
            ShowSubmenu(pnlSubCourse);
        }

        private void btnStudentCourse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CourseForm());
        }

        private void btnManageCourse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageCourseForm());
        }

        private void btnCoursePrint_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PrintCourseForm());
        }

        #endregion CourseSubmenu

        #region Group of Score button
        private void btnScore_Click(object sender, EventArgs e)
        {
            EnableButton(sender as Button);
            ShowSubmenu(pnlSubScore);
        }

        private void btnManageScore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageScoreForm());
        }

        private void btnScorePrint_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PrintScoreForm());
        }
        #endregion ScoreSubmenu

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            //if (activeForm != null)
            //    activeForm.Close();
            //pnlMain.Controls.Add(panel_cover);
            //studentCount();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = cbbCourse.GetItemText(cbbCourse.SelectedItem);
            //lbCourseMale.Text = "Male : " + student.ExeCount("SELECT COUNT(*) FROM student INNER JOIN score INNER JOIN course ON student.StdId=score.StudentId AND score.CourseId=course.CourseId WHERE course.CourseName='" + cbbCourse.GetItemText(cbbCourse.SelectedItem) +"' AND `Gender`= 'Male'");
            //lbCourseFemale.Text = "Female : " + student.ExeCount("SELECT COUNT(*) FROM student INNER JOIN score INNER JOIN course ON student.StdId=score.StudentId AND score.CourseId=course.CourseId WHERE course.CourseName='" + cbbCourse.GetItemText(cbbCourse.SelectedItem) + "' AND `Gender`= 'Female'");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
                Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm();
        }
    }
}