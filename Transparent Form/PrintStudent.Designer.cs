
namespace Transparent_Form
{
    partial class PrintStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_print = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridView_student = new System.Windows.Forms.DataGridView();
            this.sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // button_print
            // 
            this.button_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(800, 562);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(118, 39);
            this.button_print.TabIndex = 29;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Print Student List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 46);
            this.panel1.TabIndex = 16;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.Color.LimeGreen;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(804, 50);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(118, 39);
            this.button_search.TabIndex = 29;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Location = new System.Drawing.Point(618, 55);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(180, 38);
            this.comboBox_gender.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(498, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Gender :";
            // 
            // DataGridView_student
            // 
            this.DataGridView_student.AllowUserToAddRows = false;
            this.DataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_student.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sId,
            this.sFname,
            this.sLname,
            this.sBirthday,
            this.sGender,
            this.sPhone,
            this.sAddress,
            this.sPhoto});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_student.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_student.EnableHeadersVisualStyles = false;
            this.DataGridView_student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.DataGridView_student.Location = new System.Drawing.Point(13, 95);
            this.DataGridView_student.Name = "DataGridView_student";
            this.DataGridView_student.ReadOnly = true;
            this.DataGridView_student.RowHeadersVisible = false;
            this.DataGridView_student.RowHeadersWidth = 20;
            this.DataGridView_student.RowTemplate.Height = 80;
            this.DataGridView_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_student.Size = new System.Drawing.Size(909, 460);
            this.DataGridView_student.TabIndex = 35;
            // 
            // sId
            // 
            this.sId.DataPropertyName = "StdId";
            this.sId.HeaderText = "ID";
            this.sId.MinimumWidth = 6;
            this.sId.Name = "sId";
            this.sId.ReadOnly = true;
            // 
            // sFname
            // 
            this.sFname.DataPropertyName = "StdFirstName";
            this.sFname.HeaderText = "First Name";
            this.sFname.MinimumWidth = 6;
            this.sFname.Name = "sFname";
            this.sFname.ReadOnly = true;
            // 
            // sLname
            // 
            this.sLname.DataPropertyName = "StdLastName";
            this.sLname.HeaderText = "Last Name";
            this.sLname.MinimumWidth = 6;
            this.sLname.Name = "sLname";
            this.sLname.ReadOnly = true;
            // 
            // sBirthday
            // 
            this.sBirthday.DataPropertyName = "Birthdate";
            this.sBirthday.HeaderText = "Day of Birth";
            this.sBirthday.MinimumWidth = 6;
            this.sBirthday.Name = "sBirthday";
            this.sBirthday.ReadOnly = true;
            // 
            // sGender
            // 
            this.sGender.DataPropertyName = "Gender";
            this.sGender.HeaderText = "Gender";
            this.sGender.MinimumWidth = 6;
            this.sGender.Name = "sGender";
            this.sGender.ReadOnly = true;
            // 
            // sPhone
            // 
            this.sPhone.DataPropertyName = "Phone";
            this.sPhone.HeaderText = "Phone Number";
            this.sPhone.MinimumWidth = 6;
            this.sPhone.Name = "sPhone";
            this.sPhone.ReadOnly = true;
            // 
            // sAddress
            // 
            this.sAddress.DataPropertyName = "Address";
            this.sAddress.HeaderText = "Address";
            this.sAddress.MinimumWidth = 6;
            this.sAddress.Name = "sAddress";
            this.sAddress.ReadOnly = true;
            // 
            // sPhoto
            // 
            this.sPhoto.DataPropertyName = "Photo";
            this.sPhoto.HeaderText = "Photo";
            this.sPhoto.MinimumWidth = 6;
            this.sPhoto.Name = "sPhoto";
            this.sPhoto.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 567);
            this.panel4.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(924, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 567);
            this.panel5.TabIndex = 38;
            // 
            // PrintStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 613);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DataGridView_student);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PrintStudent";
            this.Text = "PrintStudent";
            this.Load += new System.EventHandler(this.PrintStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridView_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn sId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddress;
        private System.Windows.Forms.DataGridViewImageColumn sPhoto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}