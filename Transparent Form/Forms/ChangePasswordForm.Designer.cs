namespace Transparent_Form.Forms
{
    partial class ChangePasswordForm
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
            this.panel_changePass = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCheckNewPass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_savePassword = new System.Windows.Forms.Button();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel_changePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_changePass
            // 
            this.panel_changePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_changePass.Controls.Add(this.btnCancel);
            this.panel_changePass.Controls.Add(this.txtCheckNewPass);
            this.panel_changePass.Controls.Add(this.label14);
            this.panel_changePass.Controls.Add(this.label15);
            this.panel_changePass.Controls.Add(this.txtNewPass);
            this.panel_changePass.Controls.Add(this.label16);
            this.panel_changePass.Controls.Add(this.button_savePassword);
            this.panel_changePass.Controls.Add(this.txtCurrentPass);
            this.panel_changePass.Controls.Add(this.label17);
            this.panel_changePass.Location = new System.Drawing.Point(0, 0);
            this.panel_changePass.Name = "panel_changePass";
            this.panel_changePass.Size = new System.Drawing.Size(512, 312);
            this.panel_changePass.TabIndex = 77;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnCancel.Location = new System.Drawing.Point(121, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 39);
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCheckNewPass
            // 
            this.txtCheckNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCheckNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckNewPass.Location = new System.Drawing.Point(190, 173);
            this.txtCheckNewPass.Name = "txtCheckNewPass";
            this.txtCheckNewPass.Size = new System.Drawing.Size(292, 27);
            this.txtCheckNewPass.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label14.Location = new System.Drawing.Point(25, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 38);
            this.label14.TabIndex = 76;
            this.label14.Text = "Confirm \r\nNew Password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label15.Location = new System.Drawing.Point(155, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 25);
            this.label15.TabIndex = 75;
            this.label15.Text = "Change Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(190, 126);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(292, 27);
            this.txtNewPass.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label16.Location = new System.Drawing.Point(25, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 19);
            this.label16.TabIndex = 73;
            this.label16.Text = "New Password :";
            // 
            // button_savePassword
            // 
            this.button_savePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_savePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.button_savePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_savePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_savePassword.ForeColor = System.Drawing.Color.White;
            this.button_savePassword.Location = new System.Drawing.Point(260, 248);
            this.button_savePassword.Name = "button_savePassword";
            this.button_savePassword.Size = new System.Drawing.Size(118, 39);
            this.button_savePassword.TabIndex = 71;
            this.button_savePassword.Text = "Save";
            this.button_savePassword.UseVisualStyleBackColor = false;
            this.button_savePassword.Click += new System.EventHandler(this.button_savePassword_Click);
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.Location = new System.Drawing.Point(190, 82);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(292, 27);
            this.txtCurrentPass.TabIndex = 67;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label17.Location = new System.Drawing.Point(25, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 19);
            this.label17.TabIndex = 66;
            this.label17.Text = "Current Password :";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(512, 312);
            this.Controls.Add(this.panel_changePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.panel_changePass.ResumeLayout(false);
            this.panel_changePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_changePass;
        private System.Windows.Forms.TextBox txtCheckNewPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_savePassword;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCancel;
    }
}