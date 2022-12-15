namespace Transparent_Form.Forms
{
    partial class StudentForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCover = new System.Windows.Forms.Panel();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCourses = new System.Windows.Forms.Button();
            this.pnlSubCourse = new System.Windows.Forms.Panel();
            this.btnMyCourses = new System.Windows.Forms.Button();
            this.btnAllCourses = new System.Windows.Forms.Button();
            this.btnMyScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCover.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.pnlSubCourse.SuspendLayout();
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
            this.pnlTop.TabIndex = 1;
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
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.AutoScroll = true;
            this.pnlNavigation.BackColor = System.Drawing.Color.White;
            this.pnlNavigation.Controls.Add(this.btnExit);
            this.pnlNavigation.Controls.Add(this.btnMyScores);
            this.pnlNavigation.Controls.Add(this.pnlSubCourse);
            this.pnlNavigation.Controls.Add(this.btnCourses);
            this.pnlNavigation.Controls.Add(this.btnDashboard);
            this.pnlNavigation.Controls.Add(this.pnlLogo);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 40);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(5);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 610);
            this.pnlNavigation.TabIndex = 3;
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
            this.btnDashboard.Location = new System.Drawing.Point(0, 92);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 55);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
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
            this.pnlLogo.Size = new System.Drawing.Size(200, 92);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlCover);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(950, 610);
            this.pnlMain.TabIndex = 5;
            // 
            // pnlCover
            // 
            this.pnlCover.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlCover.Controls.Add(this.pnlWelcome);
            this.pnlCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCover.Location = new System.Drawing.Point(0, 0);
            this.pnlCover.Name = "pnlCover";
            this.pnlCover.Size = new System.Drawing.Size(950, 610);
            this.pnlCover.TabIndex = 1;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.White;
            this.pnlWelcome.Controls.Add(this.label7);
            this.pnlWelcome.Controls.Add(this.label1);
            this.pnlWelcome.Controls.Add(this.lbUsername);
            this.pnlWelcome.Controls.Add(this.lbWelcome);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcome.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(950, 46);
            this.pnlWelcome.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dashboard";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbUsername.Location = new System.Drawing.Point(801, 7);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(62, 22);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "name";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbWelcome.Location = new System.Drawing.Point(707, 8);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(100, 21);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(857, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "(student)";
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.White;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCourses.Location = new System.Drawing.Point(0, 147);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(5);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCourses.Size = new System.Drawing.Size(200, 55);
            this.btnCourses.TabIndex = 15;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.UseVisualStyleBackColor = false;
            // 
            // pnlSubCourse
            // 
            this.pnlSubCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(200)))));
            this.pnlSubCourse.Controls.Add(this.btnAllCourses);
            this.pnlSubCourse.Controls.Add(this.btnMyCourses);
            this.pnlSubCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubCourse.Location = new System.Drawing.Point(0, 202);
            this.pnlSubCourse.Name = "pnlSubCourse";
            this.pnlSubCourse.Size = new System.Drawing.Size(200, 100);
            this.pnlSubCourse.TabIndex = 16;
            // 
            // btnMyCourses
            // 
            this.btnMyCourses.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMyCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyCourses.FlatAppearance.BorderSize = 0;
            this.btnMyCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyCourses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnMyCourses.Location = new System.Drawing.Point(0, 0);
            this.btnMyCourses.Name = "btnMyCourses";
            this.btnMyCourses.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMyCourses.Size = new System.Drawing.Size(200, 50);
            this.btnMyCourses.TabIndex = 0;
            this.btnMyCourses.Text = "My Courses";
            this.btnMyCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyCourses.UseVisualStyleBackColor = false;
            // 
            // btnAllCourses
            // 
            this.btnAllCourses.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAllCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllCourses.FlatAppearance.BorderSize = 0;
            this.btnAllCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllCourses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAllCourses.Location = new System.Drawing.Point(0, 50);
            this.btnAllCourses.Name = "btnAllCourses";
            this.btnAllCourses.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAllCourses.Size = new System.Drawing.Size(200, 50);
            this.btnAllCourses.TabIndex = 1;
            this.btnAllCourses.Text = "All Courses";
            this.btnAllCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllCourses.UseVisualStyleBackColor = false;
            // 
            // btnMyScores
            // 
            this.btnMyScores.BackColor = System.Drawing.Color.White;
            this.btnMyScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyScores.FlatAppearance.BorderSize = 0;
            this.btnMyScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyScores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnMyScores.Location = new System.Drawing.Point(0, 302);
            this.btnMyScores.Margin = new System.Windows.Forms.Padding(5);
            this.btnMyScores.Name = "btnMyScores";
            this.btnMyScores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMyScores.Size = new System.Drawing.Size(200, 55);
            this.btnMyScores.TabIndex = 23;
            this.btnMyScores.Text = "My Scores";
            this.btnMyScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyScores.UseVisualStyleBackColor = false;
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
            this.btnExit.Location = new System.Drawing.Point(0, 357);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(200, 55);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Log out";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlCover.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.pnlSubCourse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCover;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Panel pnlSubCourse;
        private System.Windows.Forms.Button btnAllCourses;
        private System.Windows.Forms.Button btnMyCourses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMyScores;
    }
}