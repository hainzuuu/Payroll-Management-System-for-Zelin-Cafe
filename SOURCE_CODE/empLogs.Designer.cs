namespace APPLICATION_DEVELOPMENT_3
{
    partial class empLogs
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
            this.buttonExportLogs = new System.Windows.Forms.Button();
            this.dataGridViewEmpLogs = new System.Windows.Forms.DataGridView();
            this.checkBoxDateEnabled = new System.Windows.Forms.CheckBox();
            this.dateTimePickerLogs = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExportLogs
            // 
            this.buttonExportLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonExportLogs.FlatAppearance.BorderSize = 0;
            this.buttonExportLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportLogs.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExportLogs.ForeColor = System.Drawing.Color.White;
            this.buttonExportLogs.Location = new System.Drawing.Point(671, 543);
            this.buttonExportLogs.Name = "buttonExportLogs";
            this.buttonExportLogs.Size = new System.Drawing.Size(157, 36);
            this.buttonExportLogs.TabIndex = 35;
            this.buttonExportLogs.Text = "Export";
            this.buttonExportLogs.UseVisualStyleBackColor = false;
            this.buttonExportLogs.Click += new System.EventHandler(this.buttonExportLogs_Click);
            // 
            // dataGridViewEmpLogs
            // 
            this.dataGridViewEmpLogs.AllowUserToAddRows = false;
            this.dataGridViewEmpLogs.AllowUserToDeleteRows = false;
            this.dataGridViewEmpLogs.AllowUserToResizeColumns = false;
            this.dataGridViewEmpLogs.AllowUserToResizeRows = false;
            this.dataGridViewEmpLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmpLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEmpLogs.Location = new System.Drawing.Point(19, 106);
            this.dataGridViewEmpLogs.Name = "dataGridViewEmpLogs";
            this.dataGridViewEmpLogs.ReadOnly = true;
            this.dataGridViewEmpLogs.RowTemplate.Height = 25;
            this.dataGridViewEmpLogs.ShowCellErrors = false;
            this.dataGridViewEmpLogs.ShowCellToolTips = false;
            this.dataGridViewEmpLogs.ShowEditingIcon = false;
            this.dataGridViewEmpLogs.ShowRowErrors = false;
            this.dataGridViewEmpLogs.Size = new System.Drawing.Size(812, 420);
            this.dataGridViewEmpLogs.TabIndex = 33;
            // 
            // checkBoxDateEnabled
            // 
            this.checkBoxDateEnabled.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDateEnabled.Location = new System.Drawing.Point(479, 76);
            this.checkBoxDateEnabled.Name = "checkBoxDateEnabled";
            this.checkBoxDateEnabled.Size = new System.Drawing.Size(20, 20);
            this.checkBoxDateEnabled.TabIndex = 39;
            this.checkBoxDateEnabled.UseVisualStyleBackColor = true;
            this.checkBoxDateEnabled.CheckedChanged += new System.EventHandler(this.checkBoxDateEnabled_CheckedChanged);
            // 
            // dateTimePickerLogs
            // 
            this.dateTimePickerLogs.Enabled = false;
            this.dateTimePickerLogs.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerLogs.Location = new System.Drawing.Point(505, 67);
            this.dateTimePickerLogs.Name = "dateTimePickerLogs";
            this.dateTimePickerLogs.Size = new System.Drawing.Size(326, 33);
            this.dateTimePickerLogs.TabIndex = 38;
            this.dateTimePickerLogs.ValueChanged += new System.EventHandler(this.dateTimePickerLogs_ValueChanged);
            // 
            // empLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 642);
            this.Controls.Add(this.checkBoxDateEnabled);
            this.Controls.Add(this.dateTimePickerLogs);
            this.Controls.Add(this.buttonExportLogs);
            this.Controls.Add(this.dataGridViewEmpLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "empLogs";
            this.Load += new System.EventHandler(this.empLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonExportLogs;
        private DataGridView dataGridViewEmpLogs;
        private CheckBox checkBoxDateEnabled;
        private DateTimePicker dateTimePickerLogs;
    }
}