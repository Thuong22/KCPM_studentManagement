
namespace Transparent_Form
{
    partial class ManageStudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Lname = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.pictureBox_student = new System.Windows.Forms.PictureBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manage Students";
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
            this.button_search.TabIndex = 33;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(642, 55);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(156, 27);
            this.textBox_search.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(21, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date Of Birth :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(21, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address :";
            // 
            // textBox_Fname
            // 
            this.textBox_Fname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Fname.Location = new System.Drawing.Point(134, 24);
            this.textBox_Fname.Name = "textBox_Fname";
            this.textBox_Fname.Size = new System.Drawing.Size(140, 27);
            this.textBox_Fname.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(515, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(280, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Last Name :";
            // 
            // textBox_Lname
            // 
            this.textBox_Lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Lname.Location = new System.Drawing.Point(384, 24);
            this.textBox_Lname.Name = "textBox_Lname";
            this.textBox_Lname.Size = new System.Drawing.Size(135, 27);
            this.textBox_Lname.TabIndex = 21;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirth.Location = new System.Drawing.Point(134, 70);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(291, 27);
            this.dtpBirth.TabIndex = 22;
            // 
            // radioButton_male
            // 
            this.radioButton_male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Checked = true;
            this.radioButton_male.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.radioButton_male.Location = new System.Drawing.Point(603, 72);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(66, 23);
            this.radioButton_male.TabIndex = 23;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.radioButton_female.Location = new System.Drawing.Point(685, 72);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(84, 23);
            this.radioButton_female.TabIndex = 24;
            this.radioButton_female.Text = "FeMale";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // textBox_address
            // 
            this.textBox_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_address.Location = new System.Drawing.Point(134, 114);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(458, 64);
            this.textBox_address.TabIndex = 25;
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_student.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_student.Location = new System.Drawing.Point(799, 24);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.Size = new System.Drawing.Size(118, 110);
            this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_student.TabIndex = 26;
            this.pictureBox_student.TabStop = false;
            // 
            // button_upload
            // 
            this.button_upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_upload.BackColor = System.Drawing.Color.LimeGreen;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(799, 140);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(118, 39);
            this.button_upload.TabIndex = 27;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(675, 188);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(118, 39);
            this.button_update.TabIndex = 28;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(799, 188);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(118, 39);
            this.button_delete.TabIndex = 29;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(528, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Phone :";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_phone.Location = new System.Drawing.Point(602, 24);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(168, 27);
            this.textBox_phone.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(598, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Id No :";
            // 
            // textBox_id
            // 
            this.textBox_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_id.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_id.Location = new System.Drawing.Point(670, 111);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(100, 27);
            this.textBox_id.TabIndex = 31;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 10);
            this.panel3.TabIndex = 32;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.Color.LimeGreen;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(427, 188);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(118, 39);
            this.button_clear.TabIndex = 33;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(551, 188);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(118, 39);
            this.button_add.TabIndex = 34;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox_phone);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_update);
            this.panel2.Controls.Add(this.button_upload);
            this.panel2.Controls.Add(this.pictureBox_student);
            this.panel2.Controls.Add(this.textBox_address);
            this.panel2.Controls.Add(this.radioButton_female);
            this.panel2.Controls.Add(this.radioButton_male);
            this.panel2.Controls.Add(this.dtpBirth);
            this.panel2.Controls.Add(this.textBox_Lname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_Fname);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 235);
            this.panel2.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(924, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 225);
            this.panel7.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 225);
            this.panel6.TabIndex = 36;
            // 
            // DataGridView_student
            // 
            this.DataGridView_student.AllowUserToAddRows = false;
            this.DataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_student.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_student.EnableHeadersVisualStyles = false;
            this.DataGridView_student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.DataGridView_student.Location = new System.Drawing.Point(13, 93);
            this.DataGridView_student.Name = "DataGridView_student";
            this.DataGridView_student.ReadOnly = true;
            this.DataGridView_student.RowHeadersVisible = false;
            this.DataGridView_student.RowHeadersWidth = 20;
            this.DataGridView_student.RowTemplate.Height = 80;
            this.DataGridView_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_student.Size = new System.Drawing.Size(909, 281);
            this.DataGridView_student.TabIndex = 34;
            this.DataGridView_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_student_Click);
            // 
            // sId
            // 
            this.sId.DataPropertyName = "AccId";
            this.sId.HeaderText = "ID";
            this.sId.MinimumWidth = 6;
            this.sId.Name = "sId";
            this.sId.ReadOnly = true;
            // 
            // sFname
            // 
            this.sFname.DataPropertyName = "AccFirstName";
            this.sFname.HeaderText = "First Name";
            this.sFname.MinimumWidth = 6;
            this.sFname.Name = "sFname";
            this.sFname.ReadOnly = true;
            // 
            // sLname
            // 
            this.sLname.DataPropertyName = "AccLastName";
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
            this.panel4.Size = new System.Drawing.Size(10, 332);
            this.panel4.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(924, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 332);
            this.panel5.TabIndex = 37;
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 613);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DataGridView_student);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageStudentForm";
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Lname;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.PictureBox pictureBox_student;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataGridView_student;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
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