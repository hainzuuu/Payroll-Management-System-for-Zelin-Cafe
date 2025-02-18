namespace APPLICATION_DEVELOPMENT_3
{
    partial class empDashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.buttonIN = new System.Windows.Forms.Button();
            this.buttonOUT = new System.Windows.Forms.Button();
            this.labelIN = new System.Windows.Forms.Label();
            this.labelOUT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 113);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APPLICATION_DEVELOPMENT_3.Properties.Resources.toppng_com_clock_icon_400x400_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.labelDate.Location = new System.Drawing.Point(114, 61);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 25);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.labelStatus.Location = new System.Drawing.Point(663, 39);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(132, 37);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "•OFFLINE";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.labelTime.Location = new System.Drawing.Point(110, 19);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(77, 37);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // buttonIN
            // 
            this.buttonIN.BackColor = System.Drawing.Color.White;
            this.buttonIN.FlatAppearance.BorderSize = 2;
            this.buttonIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIN.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonIN.Location = new System.Drawing.Point(37, 131);
            this.buttonIN.Name = "buttonIN";
            this.buttonIN.Size = new System.Drawing.Size(380, 260);
            this.buttonIN.TabIndex = 29;
            this.buttonIN.Text = "Time-IN";
            this.buttonIN.UseVisualStyleBackColor = false;
            this.buttonIN.Click += new System.EventHandler(this.buttonIN_Click);
            // 
            // buttonOUT
            // 
            this.buttonOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonOUT.Enabled = false;
            this.buttonOUT.FlatAppearance.BorderSize = 0;
            this.buttonOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOUT.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOUT.ForeColor = System.Drawing.Color.White;
            this.buttonOUT.Location = new System.Drawing.Point(411, 131);
            this.buttonOUT.Name = "buttonOUT";
            this.buttonOUT.Size = new System.Drawing.Size(400, 260);
            this.buttonOUT.TabIndex = 29;
            this.buttonOUT.Text = "Time-OUT";
            this.buttonOUT.UseVisualStyleBackColor = false;
            this.buttonOUT.Click += new System.EventHandler(this.buttonOUT_Click);
            // 
            // labelIN
            // 
            this.labelIN.AutoSize = true;
            this.labelIN.BackColor = System.Drawing.Color.Transparent;
            this.labelIN.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.labelIN.Location = new System.Drawing.Point(185, 249);
            this.labelIN.Name = "labelIN";
            this.labelIN.Size = new System.Drawing.Size(83, 25);
            this.labelIN.TabIndex = 8;
            this.labelIN.Text = "Time-IN";
            this.labelIN.Visible = false;
            this.labelIN.Click += new System.EventHandler(this.labelIN_Click);
            // 
            // labelOUT
            // 
            this.labelOUT.AutoSize = true;
            this.labelOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.labelOUT.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOUT.ForeColor = System.Drawing.Color.White;
            this.labelOUT.Location = new System.Drawing.Point(559, 249);
            this.labelOUT.Name = "labelOUT";
            this.labelOUT.Size = new System.Drawing.Size(99, 25);
            this.labelOUT.TabIndex = 8;
            this.labelOUT.Text = "Time-OUT";
            this.labelOUT.Click += new System.EventHandler(this.labelOUT_Click);
            // 
            // empDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 642);
            this.Controls.Add(this.labelOUT);
            this.Controls.Add(this.buttonOUT);
            this.Controls.Add(this.labelIN);
            this.Controls.Add(this.buttonIN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "empDashboard";
            this.Load += new System.EventHandler(this.empDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelDate;
        private Label labelTime;
        private System.Windows.Forms.Timer timerDateTime;
        private Label labelStatus;
        private Button buttonIN;
        private Button buttonOUT;
        private Label labelIN;
        private Label labelOUT;
    }
}