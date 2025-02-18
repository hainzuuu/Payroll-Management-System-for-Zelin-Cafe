namespace APPLICATION_DEVELOPMENT_3
{
    partial class empAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmNewPW = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelValNewPW = new System.Windows.Forms.Label();
            this.labelValWrongPW = new System.Windows.Forms.Label();
            this.labelValConfirmPw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxOldPassword);
            this.groupBox1.Controls.Add(this.textBoxConfirmNewPW);
            this.groupBox1.Controls.Add(this.textBoxNewPassword);
            this.groupBox1.Controls.Add(this.labelValNewPW);
            this.groupBox1.Controls.Add(this.labelValWrongPW);
            this.groupBox1.Controls.Add(this.labelValConfirmPw);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 236);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Old Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(174, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "must have at least 4 characters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm PW";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOldPassword.Location = new System.Drawing.Point(165, 66);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(203, 29);
            this.textBoxOldPassword.TabIndex = 6;
            this.textBoxOldPassword.TextChanged += new System.EventHandler(this.textBoxOldPassword_TextChanged);
            // 
            // textBoxConfirmNewPW
            // 
            this.textBoxConfirmNewPW.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxConfirmNewPW.Location = new System.Drawing.Point(165, 168);
            this.textBoxConfirmNewPW.Name = "textBoxConfirmNewPW";
            this.textBoxConfirmNewPW.PasswordChar = '*';
            this.textBoxConfirmNewPW.Size = new System.Drawing.Size(203, 29);
            this.textBoxConfirmNewPW.TabIndex = 6;
            this.textBoxConfirmNewPW.TextChanged += new System.EventHandler(this.textBoxConfirmNewPW_TextChanged);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewPassword.Location = new System.Drawing.Point(165, 117);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(203, 29);
            this.textBoxNewPassword.TabIndex = 6;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.textBoxNewPassword_TextChanged);
            // 
            // labelValNewPW
            // 
            this.labelValNewPW.AutoSize = true;
            this.labelValNewPW.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValNewPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelValNewPW.Location = new System.Drawing.Point(165, 99);
            this.labelValNewPW.Name = "labelValNewPW";
            this.labelValNewPW.Size = new System.Drawing.Size(12, 15);
            this.labelValNewPW.TabIndex = 4;
            this.labelValNewPW.Text = "*";
            this.labelValNewPW.Visible = false;
            // 
            // labelValWrongPW
            // 
            this.labelValWrongPW.AutoSize = true;
            this.labelValWrongPW.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValWrongPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelValWrongPW.Location = new System.Drawing.Point(165, 48);
            this.labelValWrongPW.Name = "labelValWrongPW";
            this.labelValWrongPW.Size = new System.Drawing.Size(96, 15);
            this.labelValWrongPW.TabIndex = 4;
            this.labelValWrongPW.Text = "Wrong password";
            this.labelValWrongPW.Visible = false;
            // 
            // labelValConfirmPw
            // 
            this.labelValConfirmPw.AutoSize = true;
            this.labelValConfirmPw.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValConfirmPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelValConfirmPw.Location = new System.Drawing.Point(165, 153);
            this.labelValConfirmPw.Name = "labelValConfirmPw";
            this.labelValConfirmPw.Size = new System.Drawing.Size(90, 15);
            this.labelValConfirmPw.TabIndex = 4;
            this.labelValConfirmPw.Text = "Does not match";
            this.labelValConfirmPw.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(645, 278);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(157, 36);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // empAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 642);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "empAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label9;
        private Label label2;
        private TextBox textBoxOldPassword;
        private TextBox textBoxConfirmNewPW;
        private TextBox textBoxNewPassword;
        private Label labelValNewPW;
        private Label labelValConfirmPw;
        private Label label3;
        private Label labelValWrongPW;
        private Button buttonSave;
    }
}