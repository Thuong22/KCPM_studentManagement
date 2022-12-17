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
using Transparent_Form.Models;

namespace Transparent_Form.Forms
{
    public partial class StudentForm : Form
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
        bool isLogout = false;
        Form activeForm;
        Button curButton;
        public static Account account;

        public StudentForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            student = new Student();
            EnableButton(btnDashboard);

            lbUsername.Text = account.username;
            lbUsername.Location = new Point(pnlWelcome.Width - (lbUsername.Size.Width + 87), lbUsername.Location.Y);
            lbWelcome.Location = new Point(pnlWelcome.Width - (lbWelcome.Size.Width + lbUsername.Size.Width + 81), lbWelcome.Location.Y);

            //var data = student.GetStudentList("")

            //student = student.GetStudentList

            //lbName.Text = 
        }

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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            EnableButton(sender as Button);
            if (activeForm != null)
                activeForm.Close();
            pnlMain.Controls.Add(pnlCover);
        }

        private void btnMyCourses_Click(object sender, EventArgs e)
        {
            EnableButton(sender as Button);
            OpenChildForm(new MyCoursesForm());
        }

        private void btnAllCourses_Click(object sender, EventArgs e)
        {
            EnableButton(sender as Button);
            OpenChildForm(new AllCoursesForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
                Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditProfile());
        }
    }
}
