namespace APPLICATION_DEVELOPMENT_3
{
    partial class Employee1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonLogs = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonAccount);
            this.panel1.Controls.Add(this.buttonLogs);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 642);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelEmpName);
            this.panel2.Location = new System.Drawing.Point(22, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 32);
            this.panel2.TabIndex = 5;
            // 
            // labelEmpName
            // 
            this.labelEmpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmpName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmpName.ForeColor = System.Drawing.Color.Black;
            this.labelEmpName.Location = new System.Drawing.Point(0, 0);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(100, 32);
            this.labelEmpName.TabIndex = 3;
            this.labelEmpName.Text = "Employee";
            this.labelEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccount.ForeColor = System.Drawing.Color.Black;
            this.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.Location = new System.Drawing.Point(0, 262);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(144, 52);
            this.buttonAccount.TabIndex = 4;
            this.buttonAccount.Text = "ACCOUNT";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonLogs
            // 
            this.buttonLogs.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogs.FlatAppearance.BorderSize = 0;
            this.buttonLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogs.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogs.ForeColor = System.Drawing.Color.Black;
            this.buttonLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogs.Location = new System.Drawing.Point(0, 214);
            this.buttonLogs.Name = "buttonLogs";
            this.buttonLogs.Size = new System.Drawing.Size(144, 50);
            this.buttonLogs.TabIndex = 4;
            this.buttonLogs.Text = "LOGS";
            this.buttonLogs.UseVisualStyleBackColor = false;
            this.buttonLogs.Click += new System.EventHandler(this.buttonLogs_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDashboard.ForeColor = System.Drawing.Color.Black;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 166);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(144, 50);
            this.buttonDashboard.TabIndex = 4;
            this.buttonDashboard.Text = "DASHBOARD";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APPLICATION_DEVELOPMENT_3.Properties.Resources.kisspng_computer_icons_silhouette_my_account_icon_5b388d486ee876_1608773115304328404543_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(142, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(850, 642);
            this.panelMain.TabIndex = 4;
            // 
            // Employee1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 642);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee1_FormClosing);
            this.Load += new System.EventHandler(this.Employee1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonAccount;
        private Button buttonLogs;
        private Button buttonDashboard;
        private Label labelEmpName;
        private PictureBox pictureBox1;
        private Panel panelMain;
        private Panel panel2;
    }
}