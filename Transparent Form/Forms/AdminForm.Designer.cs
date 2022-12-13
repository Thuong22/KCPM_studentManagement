
namespace Transparent_Form
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnManageScore = new System.Windows.Forms.Button();
            this.pnlSubScore = new System.Windows.Forms.Panel();
            this.btnScorePrint = new System.Windows.Forms.Button();
            this.btnManageStd = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManageCourse = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.pnlSubStudent = new System.Windows.Forms.Panel();
            this.btnStudentPrint = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnCoursePrint = new System.Windows.Forms.Button();
            this.pnlSubCourse = new System.Windows.Forms.Panel();
            this.btnStudentCourse = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCourseFemale = new System.Windows.Forms.Label();
            this.lbCourseMale = new System.Windows.Forms.Label();
            this.cbbCourse = new System.Windows.Forms.ComboBox();
            this.lbFemale = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalStudent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlSubScore.SuspendLayout();
            this.pnlSubStudent.SuspendLayout();
            this.pnlSubCourse.SuspendLayout();
            this.pnlSlide.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1150, 40);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Transparent_Form.Properties.Resources.icon_close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1111, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnExit.Location = new System.Drawing.Point(0, 663);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(183, 55);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Log out";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnManageScore
            // 
            this.btnManageScore.BackColor = System.Drawing.Color.AliceBlue;
            this.btnManageScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageScore.FlatAppearance.BorderSize = 0;
            this.btnManageScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnManageScore.Location = new System.Drawing.Point(0, 0);
            this.btnManageScore.Name = "btnManageScore";
            this.btnManageScore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManageScore.Size = new System.Drawing.Size(183, 50);
            this.btnManageScore.TabIndex = 1;
            this.btnManageScore.Text = "Manage Score";
            this.btnManageScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageScore.UseVisualStyleBackColor = false;
            this.btnManageScore.Click += new System.EventHandler(this.btnManageScore_Click);
            // 
            // pnlSubScore
            // 
            this.pnlSubScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(200)))));
            this.pnlSubScore.Controls.Add(this.btnScorePrint);
            this.pnlSubScore.Controls.Add(this.btnManageScore);
            this.pnlSubScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubScore.Location = new System.Drawing.Point(0, 508);
            this.pnlSubScore.Name = "pnlSubScore";
            this.pnlSubScore.Size = new System.Drawing.Size(183, 100);
            this.pnlSubScore.TabIndex = 6;
            // 
            // btnScorePrint
            // 
            this.btnScorePrint.BackColor = System.Drawing.Color.AliceBlue;
            this.btnScorePrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScorePrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScorePrint.FlatAppearance.BorderSize = 0;
            this.btnScorePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScorePrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScorePrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnScorePrint.Location = new System.Drawing.Point(0, 50);
            this.btnScorePrint.Name = "btnScorePrint";
            this.btnScorePrint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnScorePrint.Size = new System.Drawing.Size(183, 50);
            this.btnScorePrint.TabIndex = 3;
            this.btnScorePrint.Text = "Print";
            this.btnScorePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScorePrint.UseVisualStyleBackColor = false;
            this.btnScorePrint.Click += new System.EventHandler(this.btnScorePrint_Click);
            // 
            // btnManageStd
            // 
            this.btnManageStd.BackColor = System.Drawing.Color.AliceBlue;
            this.btnManageStd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageStd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStd.FlatAppearance.BorderSize = 0;
            this.btnManageStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnManageStd.Location = new System.Drawing.Point(0, 0);
            this.btnManageStd.Name = "btnManageStd";
            this.btnManageStd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManageStd.Size = new System.Drawing.Size(183, 50);
            this.btnManageStd.TabIndex = 1;
            this.btnManageStd.Text = "Manage Student";
            this.btnManageStd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStd.UseVisualStyleBackColor = false;
            this.btnManageStd.Click += new System.EventHandler(this.btnManageStd_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 608);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(183, 55);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnManageCourse
            // 
            this.btnManageCourse.BackColor = System.Drawing.Color.AliceBlue;
            this.btnManageCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCourse.FlatAppearance.BorderSize = 0;
            this.btnManageCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnManageCourse.Location = new System.Drawing.Point(0, 50);
            this.btnManageCourse.Name = "btnManageCourse";
            this.btnManageCourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManageCourse.Size = new System.Drawing.Size(183, 50);
            this.btnManageCourse.TabIndex = 1;
            this.btnManageCourse.Text = "Manage Course";
            this.btnManageCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCourse.UseVisualStyleBackColor = false;
            this.btnManageCourse.Click += new System.EventHandler(this.btnManageCourse_Click);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.White;
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnScore.Location = new System.Drawing.Point(0, 453);
            this.btnScore.Margin = new System.Windows.Forms.Padding(5);
            this.btnScore.Name = "btnScore";
            this.btnScore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnScore.Size = new System.Drawing.Size(183, 55);
            this.btnScore.TabIndex = 5;
            this.btnScore.Text = "Score";
            this.btnScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // pnlSubStudent
            // 
            this.pnlSubStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(200)))));
            this.pnlSubStudent.Controls.Add(this.btnStudentPrint);
            this.pnlSubStudent.Controls.Add(this.btnManageStd);
            this.pnlSubStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubStudent.Location = new System.Drawing.Point(0, 147);
            this.pnlSubStudent.Name = "pnlSubStudent";
            this.pnlSubStudent.Size = new System.Drawing.Size(183, 100);
            this.pnlSubStudent.TabIndex = 2;
            // 
            // btnStudentPrint
            // 
            this.btnStudentPrint.BackColor = System.Drawing.Color.AliceBlue;
            this.btnStudentPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentPrint.FlatAppearance.BorderSize = 0;
            this.btnStudentPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnStudentPrint.Location = new System.Drawing.Point(0, 50);
            this.btnStudentPrint.Name = "btnStudentPrint";
            this.btnStudentPrint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStudentPrint.Size = new System.Drawing.Size(183, 50);
            this.btnStudentPrint.TabIndex = 3;
            this.btnStudentPrint.Text = "Print";
            this.btnStudentPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentPrint.UseVisualStyleBackColor = false;
            this.btnStudentPrint.Click += new System.EventHandler(this.btnStudentPrint_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.White;
            this.pnlLogo.BackgroundImage = global::Transparent_Form.Properties.Resources.Logo_SmallBlue;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(183, 92);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.White;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnStudent.Location = new System.Drawing.Point(0, 92);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(5);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(183, 55);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnCoursePrint
            // 
            this.btnCoursePrint.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCoursePrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoursePrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoursePrint.FlatAppearance.BorderSize = 0;
            this.btnCoursePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoursePrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoursePrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCoursePrint.Location = new System.Drawing.Point(0, 100);
            this.btnCoursePrint.Name = "btnCoursePrint";
            this.btnCoursePrint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCoursePrint.Size = new System.Drawing.Size(183, 51);
            this.btnCoursePrint.TabIndex = 3;
            this.btnCoursePrint.Text = "Print";
            this.btnCoursePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoursePrint.UseVisualStyleBackColor = false;
            this.btnCoursePrint.Click += new System.EventHandler(this.btnCoursePrint_Click);
            // 
            // pnlSubCourse
            // 
            this.pnlSubCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(200)))));
            this.pnlSubCourse.Controls.Add(this.btnCoursePrint);
            this.pnlSubCourse.Controls.Add(this.btnManageCourse);
            this.pnlSubCourse.Controls.Add(this.btnStudentCourse);
            this.pnlSubCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubCourse.Location = new System.Drawing.Point(0, 302);
            this.pnlSubCourse.Name = "pnlSubCourse";
            this.pnlSubCourse.Size = new System.Drawing.Size(183, 151);
            this.pnlSubCourse.TabIndex = 4;
            // 
            // btnStudentCourse
            // 
            this.btnStudentCourse.BackColor = System.Drawing.Color.AliceBlue;
            this.btnStudentCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentCourse.FlatAppearance.BorderSize = 0;
            this.btnStudentCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnStudentCourse.Location = new System.Drawing.Point(0, 0);
            this.btnStudentCourse.Name = "btnStudentCourse";
            this.btnStudentCourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStudentCourse.Size = new System.Drawing.Size(183, 50);
            this.btnStudentCourse.TabIndex = 0;
            this.btnStudentCourse.Text = "Students in Course";
            this.btnStudentCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentCourse.UseVisualStyleBackColor = false;
            this.btnStudentCourse.Click += new System.EventHandler(this.btnStudentCourse_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.Color.White;
            this.btnCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCourse.Location = new System.Drawing.Point(0, 247);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(5);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCourse.Size = new System.Drawing.Size(183, 55);
            this.btnCourse.TabIndex = 3;
            this.btnCourse.Text = "Course";
            this.btnCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // pnlSlide
            // 
            this.pnlSlide.AutoScroll = true;
            this.pnlSlide.BackColor = System.Drawing.Color.White;
            this.pnlSlide.Controls.Add(this.btnExit);
            this.pnlSlide.Controls.Add(this.btnDashboard);
            this.pnlSlide.Controls.Add(this.pnlSubScore);
            this.pnlSlide.Controls.Add(this.btnScore);
            this.pnlSlide.Controls.Add(this.pnlSubCourse);
            this.pnlSlide.Controls.Add(this.btnCourse);
            this.pnlSlide.Controls.Add(this.pnlSubStudent);
            this.pnlSlide.Controls.Add(this.btnStudent);
            this.pnlSlide.Controls.Add(this.pnlLogo);
            this.pnlSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlide.Location = new System.Drawing.Point(0, 40);
            this.pnlSlide.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(200, 610);
            this.pnlSlide.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pbCover);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlWelcome);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(950, 610);
            this.pnlMain.TabIndex = 3;
            // 
            // pbCover
            // 
            this.pbCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCover.Image = ((System.Drawing.Image)(resources.GetObject("pbCover.Image")));
            this.pbCover.Location = new System.Drawing.Point(0, 35);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(950, 495);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 5;
            this.pbCover.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.label5);
            this.pnlBottom.Controls.Add(this.lbCourseFemale);
            this.pnlBottom.Controls.Add(this.lbCourseMale);
            this.pnlBottom.Controls.Add(this.cbbCourse);
            this.pnlBottom.Controls.Add(this.lbFemale);
            this.pnlBottom.Controls.Add(this.label4);
            this.pnlBottom.Controls.Add(this.lbMale);
            this.pnlBottom.Controls.Add(this.label3);
            this.pnlBottom.Controls.Add(this.lbTotalStudent);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 530);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(950, 80);
            this.pnlBottom.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(410, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select Class:";
            // 
            // lbCourseFemale
            // 
            this.lbCourseFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCourseFemale.AutoSize = true;
            this.lbCourseFemale.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbCourseFemale.Location = new System.Drawing.Point(783, 50);
            this.lbCourseFemale.Name = "lbCourseFemale";
            this.lbCourseFemale.Size = new System.Drawing.Size(85, 21);
            this.lbCourseFemale.TabIndex = 4;
            this.lbCourseFemale.Text = "Female :";
            // 
            // lbCourseMale
            // 
            this.lbCourseMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCourseMale.AutoSize = true;
            this.lbCourseMale.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbCourseMale.Location = new System.Drawing.Point(410, 50);
            this.lbCourseMale.Name = "lbCourseMale";
            this.lbCourseMale.Size = new System.Drawing.Size(64, 21);
            this.lbCourseMale.TabIndex = 5;
            this.lbCourseMale.Text = "Male :";
            // 
            // cbbCourse
            // 
            this.cbbCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.cbbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCourse.ForeColor = System.Drawing.Color.White;
            this.cbbCourse.FormattingEnabled = true;
            this.cbbCourse.Location = new System.Drawing.Point(535, 11);
            this.cbbCourse.Name = "cbbCourse";
            this.cbbCourse.Size = new System.Drawing.Size(403, 29);
            this.cbbCourse.TabIndex = 3;
            // 
            // lbFemale
            // 
            this.lbFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFemale.AutoSize = true;
            this.lbFemale.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbFemale.Location = new System.Drawing.Point(202, 51);
            this.lbFemale.Name = "lbFemale";
            this.lbFemale.Size = new System.Drawing.Size(0, 21);
            this.lbFemale.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(121, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Female:";
            // 
            // lbMale
            // 
            this.lbMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMale.AutoSize = true;
            this.lbMale.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbMale.Location = new System.Drawing.Point(75, 52);
            this.lbMale.Name = "lbMale";
            this.lbMale.Size = new System.Drawing.Size(0, 21);
            this.lbMale.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Male:";
            // 
            // lbTotalStudent
            // 
            this.lbTotalStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalStudent.AutoSize = true;
            this.lbTotalStudent.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbTotalStudent.Location = new System.Drawing.Point(149, 17);
            this.lbTotalStudent.Name = "lbTotalStudent";
            this.lbTotalStudent.Size = new System.Drawing.Size(0, 21);
            this.lbTotalStudent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Students:";
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.White;
            this.pnlWelcome.Controls.Add(this.lbUsername);
            this.pnlWelcome.Controls.Add(this.label1);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcome.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(950, 35);
            this.pnlWelcome.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbUsername.Location = new System.Drawing.Point(877, 7);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(66, 22);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(783, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSlide);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1150, 650);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OWLY Student Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlSubScore.ResumeLayout(false);
            this.pnlSubStudent.ResumeLayout(false);
            this.pnlSubCourse.ResumeLayout(false);
            this.pnlSlide.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnManageScore;
        private System.Windows.Forms.Panel pnlSubScore;
        private System.Windows.Forms.Button btnScorePrint;
        private System.Windows.Forms.Button btnManageStd;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManageCourse;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Panel pnlSubStudent;
        private System.Windows.Forms.Button btnStudentPrint;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnCoursePrint;
        private System.Windows.Forms.Panel pnlSubCourse;
        private System.Windows.Forms.Button btnStudentCourse;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCourseFemale;
        private System.Windows.Forms.Label lbCourseMale;
        private System.Windows.Forms.ComboBox cbbCourse;
        private System.Windows.Forms.Label lbFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label1;
    }
}