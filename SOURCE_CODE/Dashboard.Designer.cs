namespace APPLICATION_DEVELOPMENT_3
{
    partial class Dashboard
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
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewActive = new System.Windows.Forms.DataGridView();
            this.dataGridViewOffline = new System.Windows.Forms.DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffline)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.labelTime.Location = new System.Drawing.Point(115, 19);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(77, 37);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 113);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APPLICATION_DEVELOPMENT_3.Properties.Resources.toppng_com_clock_icon_400x400_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(23, 19);
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
            this.labelDate.Location = new System.Drawing.Point(121, 59);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 25);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // dataGridViewActive
            // 
            this.dataGridViewActive.AllowUserToAddRows = false;
            this.dataGridViewActive.AllowUserToDeleteRows = false;
            this.dataGridViewActive.AllowUserToResizeColumns = false;
            this.dataGridViewActive.AllowUserToResizeRows = false;
            this.dataGridViewActive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewActive.Location = new System.Drawing.Point(67, 196);
            this.dataGridViewActive.Name = "dataGridViewActive";
            this.dataGridViewActive.ReadOnly = true;
            this.dataGridViewActive.RowTemplate.Height = 25;
            this.dataGridViewActive.ShowCellErrors = false;
            this.dataGridViewActive.ShowCellToolTips = false;
            this.dataGridViewActive.ShowEditingIcon = false;
            this.dataGridViewActive.ShowRowErrors = false;
            this.dataGridViewActive.Size = new System.Drawing.Size(317, 340);
            this.dataGridViewActive.TabIndex = 10;
            // 
            // dataGridViewOffline
            // 
            this.dataGridViewOffline.AllowUserToAddRows = false;
            this.dataGridViewOffline.AllowUserToDeleteRows = false;
            this.dataGridViewOffline.AllowUserToResizeColumns = false;
            this.dataGridViewOffline.AllowUserToResizeRows = false;
            this.dataGridViewOffline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOffline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffline.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOffline.Location = new System.Drawing.Point(438, 196);
            this.dataGridViewOffline.Name = "dataGridViewOffline";
            this.dataGridViewOffline.ReadOnly = true;
            this.dataGridViewOffline.RowTemplate.Height = 25;
            this.dataGridViewOffline.ShowCellErrors = false;
            this.dataGridViewOffline.ShowCellToolTips = false;
            this.dataGridViewOffline.ShowEditingIcon = false;
            this.dataGridViewOffline.ShowRowErrors = false;
            this.dataGridViewOffline.Size = new System.Drawing.Size(323, 340);
            this.dataGridViewOffline.TabIndex = 10;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus.Location = new System.Drawing.Point(438, 156);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(132, 37);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "•OFFLINE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(67, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "•ACTIVE";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.dataGridViewOffline);
            this.Controls.Add(this.dataGridViewActive);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTime;
        private Panel panel1;
        private Label labelDate;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerDateTime;
        private DataGridView dataGridViewActive;
        private DataGridView dataGridViewOffline;
        private Label labelStatus;
        private Label label1;
    }
}