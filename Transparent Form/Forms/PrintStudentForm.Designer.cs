
namespace Transparent_Form
{
    partial class PrintStudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvStudent = new System.Windows.Forms.DataGridView();
            this.sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(822, 43);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 40);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbbGender
            // 
            this.cbbGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbGender.BackColor = System.Drawing.Color.White;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Location = new System.Drawing.Point(64, 54);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(240, 29);
            this.cbbGender.TabIndex = 31;
            this.cbbGender.SelectedIndexChanged += new System.EventHandler(this.cbbGender_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Filter:";
            // 
            // dtgvStudent
            // 
            this.dtgvStudent.AllowUserToAddRows = false;
            this.dtgvStudent.AllowUserToDeleteRows = false;
            this.dtgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dtgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sId,
            this.sFname,
            this.sLname,
            this.sBirthday,
            this.sGender,
            this.sPhone,
            this.sAddress,
            this.sPhoto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvStudent.EnableHeadersVisualStyles = false;
            this.dtgvStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.dtgvStudent.Location = new System.Drawing.Point(10, 95);
            this.dtgvStudent.Name = "dtgvStudent";
            this.dtgvStudent.ReadOnly = true;
            this.dtgvStudent.RowHeadersVisible = false;
            this.dtgvStudent.RowHeadersWidth = 20;
            this.dtgvStudent.RowTemplate.Height = 80;
            this.dtgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStudent.Size = new System.Drawing.Size(930, 500);
            this.dtgvStudent.TabIndex = 35;
            // 
            // sId
            // 
            this.sId.DataPropertyName = "StdId";
            this.sId.HeaderText = "ID";
            this.sId.MinimumWidth = 6;
            this.sId.Name = "sId";
            this.sId.ReadOnly = true;
            this.sId.Width = 50;
            // 
            // sFname
            // 
            this.sFname.DataPropertyName = "StdFirstName";
            this.sFname.HeaderText = "First Name";
            this.sFname.MinimumWidth = 6;
            this.sFname.Name = "sFname";
            this.sFname.ReadOnly = true;
            this.sFname.Width = 120;
            // 
            // sLname
            // 
            this.sLname.DataPropertyName = "StdLastName";
            this.sLname.HeaderText = "Last Name";
            this.sLname.MinimumWidth = 6;
            this.sLname.Name = "sLname";
            this.sLname.ReadOnly = true;
            this.sLname.Width = 120;
            // 
            // sBirthday
            // 
            this.sBirthday.DataPropertyName = "Birthdate";
            this.sBirthday.HeaderText = "Birth";
            this.sBirthday.MinimumWidth = 6;
            this.sBirthday.Name = "sBirthday";
            this.sBirthday.ReadOnly = true;
            this.sBirthday.Width = 104;
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
            this.sPhone.HeaderText = "Phone";
            this.sPhone.MinimumWidth = 6;
            this.sPhone.Name = "sPhone";
            this.sPhone.ReadOnly = true;
            this.sPhone.Width = 120;
            // 
            // sAddress
            // 
            this.sAddress.DataPropertyName = "Address";
            this.sAddress.HeaderText = "Address";
            this.sAddress.MinimumWidth = 6;
            this.sAddress.Name = "sAddress";
            this.sAddress.ReadOnly = true;
            this.sAddress.Width = 200;
            // 
            // sPhoto
            // 
            this.sPhoto.DataPropertyName = "Photo";
            this.sPhoto.HeaderText = "Photo";
            this.sPhoto.MinimumWidth = 6;
            this.sPhoto.Name = "sPhoto";
            this.sPhoto.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Print Student List";
            // 
            // PrintStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvStudent);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PrintStudentForm";
            this.Text = "PrintStudent";
            this.Load += new System.EventHandler(this.PrintStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddress;
        private System.Windows.Forms.DataGridViewImageColumn sPhoto;
    }
}