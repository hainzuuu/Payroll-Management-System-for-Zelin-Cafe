namespace APPLICATION_DEVELOPMENT_3
{
    partial class Payroll
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxIDSearch = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonNetExport = new System.Windows.Forms.Button();
            this.comboBoxCategoryNet = new System.Windows.Forms.ComboBox();
            this.textBoxDisplayName = new System.Windows.Forms.TextBox();
            this.textBoxSearchNet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNetSalary = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelValDate = new System.Windows.Forms.Label();
            this.checkBoxDateEnabledPd = new System.Windows.Forms.CheckBox();
            this.dateTimePickerPd = new System.Windows.Forms.DateTimePicker();
            this.buttonPerDayExport = new System.Windows.Forms.Button();
            this.comboBoxCategoryPd = new System.Windows.Forms.ComboBox();
            this.textBoxSearchPd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPerDaySalary = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelValDate2 = new System.Windows.Forms.Label();
            this.buttonExportHours = new System.Windows.Forms.Button();
            this.comboBoxHoursCategory = new System.Windows.Forms.ComboBox();
            this.textBoxHoursSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewHours = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetSalary)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerDaySalary)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHours)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 608);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxIDSearch);
            this.tabPage1.Controls.Add(this.buttonGenerate);
            this.tabPage1.Controls.Add(this.buttonNetExport);
            this.tabPage1.Controls.Add(this.comboBoxCategoryNet);
            this.tabPage1.Controls.Add(this.textBoxDisplayName);
            this.tabPage1.Controls.Add(this.textBoxSearchNet);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewNetSalary);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NET";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxIDSearch
            // 
            this.comboBoxIDSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxIDSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxIDSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxIDSearch.FormattingEnabled = true;
            this.comboBoxIDSearch.Location = new System.Drawing.Point(201, 15);
            this.comboBoxIDSearch.Name = "comboBoxIDSearch";
            this.comboBoxIDSearch.Size = new System.Drawing.Size(190, 29);
            this.comboBoxIDSearch.TabIndex = 39;
            this.comboBoxIDSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDSearch_SelectedIndexChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonGenerate.FlatAppearance.BorderSize = 0;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.ForeColor = System.Drawing.Color.White;
            this.buttonGenerate.Location = new System.Drawing.Point(644, 513);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(157, 36);
            this.buttonGenerate.TabIndex = 36;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonNetExport
            // 
            this.buttonNetExport.BackColor = System.Drawing.Color.White;
            this.buttonNetExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNetExport.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNetExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonNetExport.Location = new System.Drawing.Point(481, 513);
            this.buttonNetExport.Name = "buttonNetExport";
            this.buttonNetExport.Size = new System.Drawing.Size(157, 36);
            this.buttonNetExport.TabIndex = 36;
            this.buttonNetExport.Text = "Export";
            this.buttonNetExport.UseVisualStyleBackColor = false;
            this.buttonNetExport.Click += new System.EventHandler(this.buttonNetExport_Click);
            // 
            // comboBoxCategoryNet
            // 
            this.comboBoxCategoryNet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryNet.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategoryNet.FormattingEnabled = true;
            this.comboBoxCategoryNet.Items.AddRange(new object[] {
            "EID",
            "Name",
            "Year",
            "Date",
            "Total_Hours",
            "Salary"});
            this.comboBoxCategoryNet.Location = new System.Drawing.Point(630, 15);
            this.comboBoxCategoryNet.Name = "comboBoxCategoryNet";
            this.comboBoxCategoryNet.Size = new System.Drawing.Size(171, 29);
            this.comboBoxCategoryNet.TabIndex = 28;
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Enabled = false;
            this.textBoxDisplayName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDisplayName.Location = new System.Drawing.Point(201, 50);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(190, 29);
            this.textBoxDisplayName.TabIndex = 27;
            // 
            // textBoxSearchNet
            // 
            this.textBoxSearchNet.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearchNet.Location = new System.Drawing.Point(630, 50);
            this.textBoxSearchNet.Name = "textBoxSearchNet";
            this.textBoxSearchNet.Size = new System.Drawing.Size(171, 29);
            this.textBoxSearchNet.TabIndex = 27;
            this.textBoxSearchNet.TextChanged += new System.EventHandler(this.textBoxSearchNet_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generate payroll for";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(561, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // dataGridViewNetSalary
            // 
            this.dataGridViewNetSalary.AllowUserToAddRows = false;
            this.dataGridViewNetSalary.AllowUserToDeleteRows = false;
            this.dataGridViewNetSalary.AllowUserToResizeColumns = false;
            this.dataGridViewNetSalary.AllowUserToResizeRows = false;
            this.dataGridViewNetSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNetSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNetSalary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewNetSalary.Location = new System.Drawing.Point(0, 85);
            this.dataGridViewNetSalary.Name = "dataGridViewNetSalary";
            this.dataGridViewNetSalary.ReadOnly = true;
            this.dataGridViewNetSalary.RowTemplate.Height = 25;
            this.dataGridViewNetSalary.ShowCellErrors = false;
            this.dataGridViewNetSalary.ShowCellToolTips = false;
            this.dataGridViewNetSalary.ShowEditingIcon = false;
            this.dataGridViewNetSalary.ShowRowErrors = false;
            this.dataGridViewNetSalary.Size = new System.Drawing.Size(818, 409);
            this.dataGridViewNetSalary.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelValDate);
            this.tabPage2.Controls.Add(this.checkBoxDateEnabledPd);
            this.tabPage2.Controls.Add(this.dateTimePickerPd);
            this.tabPage2.Controls.Add(this.buttonPerDayExport);
            this.tabPage2.Controls.Add(this.comboBoxCategoryPd);
            this.tabPage2.Controls.Add(this.textBoxSearchPd);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewPerDaySalary);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salary/Day";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelValDate
            // 
            this.labelValDate.AutoSize = true;
            this.labelValDate.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelValDate.Location = new System.Drawing.Point(234, 2);
            this.labelValDate.Name = "labelValDate";
            this.labelValDate.Size = new System.Drawing.Size(87, 17);
            this.labelValDate.TabIndex = 41;
            this.labelValDate.Text = "YYYY-MM-DD";
            this.labelValDate.Visible = false;
            // 
            // checkBoxDateEnabledPd
            // 
            this.checkBoxDateEnabledPd.Location = new System.Drawing.Point(458, 24);
            this.checkBoxDateEnabledPd.Name = "checkBoxDateEnabledPd";
            this.checkBoxDateEnabledPd.Size = new System.Drawing.Size(20, 20);
            this.checkBoxDateEnabledPd.TabIndex = 40;
            this.checkBoxDateEnabledPd.UseVisualStyleBackColor = true;
            this.checkBoxDateEnabledPd.CheckedChanged += new System.EventHandler(this.checkBoxDateEnabledPd_CheckedChanged);
            // 
            // dateTimePickerPd
            // 
            this.dateTimePickerPd.Enabled = false;
            this.dateTimePickerPd.Location = new System.Drawing.Point(484, 17);
            this.dateTimePickerPd.Name = "dateTimePickerPd";
            this.dateTimePickerPd.Size = new System.Drawing.Size(312, 33);
            this.dateTimePickerPd.TabIndex = 39;
            this.dateTimePickerPd.ValueChanged += new System.EventHandler(this.dateTimePickerPd_ValueChanged);
            // 
            // buttonPerDayExport
            // 
            this.buttonPerDayExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonPerDayExport.FlatAppearance.BorderSize = 0;
            this.buttonPerDayExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPerDayExport.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPerDayExport.ForeColor = System.Drawing.Color.White;
            this.buttonPerDayExport.Location = new System.Drawing.Point(639, 518);
            this.buttonPerDayExport.Name = "buttonPerDayExport";
            this.buttonPerDayExport.Size = new System.Drawing.Size(157, 36);
            this.buttonPerDayExport.TabIndex = 36;
            this.buttonPerDayExport.Text = "Export";
            this.buttonPerDayExport.UseVisualStyleBackColor = false;
            this.buttonPerDayExport.Click += new System.EventHandler(this.buttonPerDayExport_Click);
            // 
            // comboBoxCategoryPd
            // 
            this.comboBoxCategoryPd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryPd.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategoryPd.FormattingEnabled = true;
            this.comboBoxCategoryPd.Items.AddRange(new object[] {
            "EID",
            "Name",
            "Date",
            "Salary"});
            this.comboBoxCategoryPd.Location = new System.Drawing.Point(86, 21);
            this.comboBoxCategoryPd.Name = "comboBoxCategoryPd";
            this.comboBoxCategoryPd.Size = new System.Drawing.Size(142, 29);
            this.comboBoxCategoryPd.TabIndex = 33;
            this.comboBoxCategoryPd.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryPd_SelectedIndexChanged);
            // 
            // textBoxSearchPd
            // 
            this.textBoxSearchPd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearchPd.Location = new System.Drawing.Point(234, 21);
            this.textBoxSearchPd.Name = "textBoxSearchPd";
            this.textBoxSearchPd.Size = new System.Drawing.Size(184, 29);
            this.textBoxSearchPd.TabIndex = 32;
            this.textBoxSearchPd.TextChanged += new System.EventHandler(this.textBoxSearchPd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Search";
            // 
            // dataGridViewPerDaySalary
            // 
            this.dataGridViewPerDaySalary.AllowUserToAddRows = false;
            this.dataGridViewPerDaySalary.AllowUserToDeleteRows = false;
            this.dataGridViewPerDaySalary.AllowUserToResizeColumns = false;
            this.dataGridViewPerDaySalary.AllowUserToResizeRows = false;
            this.dataGridViewPerDaySalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPerDaySalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerDaySalary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPerDaySalary.Location = new System.Drawing.Point(3, 66);
            this.dataGridViewPerDaySalary.Name = "dataGridViewPerDaySalary";
            this.dataGridViewPerDaySalary.ReadOnly = true;
            this.dataGridViewPerDaySalary.RowTemplate.Height = 25;
            this.dataGridViewPerDaySalary.ShowCellErrors = false;
            this.dataGridViewPerDaySalary.ShowCellToolTips = false;
            this.dataGridViewPerDaySalary.ShowEditingIcon = false;
            this.dataGridViewPerDaySalary.ShowRowErrors = false;
            this.dataGridViewPerDaySalary.Size = new System.Drawing.Size(812, 424);
            this.dataGridViewPerDaySalary.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelValDate2);
            this.tabPage3.Controls.Add(this.buttonExportHours);
            this.tabPage3.Controls.Add(this.comboBoxHoursCategory);
            this.tabPage3.Controls.Add(this.textBoxHoursSearch);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dataGridViewHours);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(818, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hours/Day";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelValDate2
            // 
            this.labelValDate2.AutoSize = true;
            this.labelValDate2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValDate2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelValDate2.Location = new System.Drawing.Point(234, 3);
            this.labelValDate2.Name = "labelValDate2";
            this.labelValDate2.Size = new System.Drawing.Size(87, 17);
            this.labelValDate2.TabIndex = 46;
            this.labelValDate2.Text = "YYYY-MM-DD";
            this.labelValDate2.Visible = false;
            // 
            // buttonExportHours
            // 
            this.buttonExportHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonExportHours.FlatAppearance.BorderSize = 0;
            this.buttonExportHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportHours.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExportHours.ForeColor = System.Drawing.Color.White;
            this.buttonExportHours.Location = new System.Drawing.Point(639, 519);
            this.buttonExportHours.Name = "buttonExportHours";
            this.buttonExportHours.Size = new System.Drawing.Size(157, 36);
            this.buttonExportHours.TabIndex = 45;
            this.buttonExportHours.Text = "Export";
            this.buttonExportHours.UseVisualStyleBackColor = false;
            this.buttonExportHours.Click += new System.EventHandler(this.buttonExportHours_Click);
            // 
            // comboBoxHoursCategory
            // 
            this.comboBoxHoursCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHoursCategory.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxHoursCategory.FormattingEnabled = true;
            this.comboBoxHoursCategory.Items.AddRange(new object[] {
            "EID",
            "Name",
            "Date",
            "Hours_gained"});
            this.comboBoxHoursCategory.Location = new System.Drawing.Point(86, 20);
            this.comboBoxHoursCategory.Name = "comboBoxHoursCategory";
            this.comboBoxHoursCategory.Size = new System.Drawing.Size(142, 29);
            this.comboBoxHoursCategory.TabIndex = 44;
            this.comboBoxHoursCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxHoursCategory_SelectedIndexChanged);
            // 
            // textBoxHoursSearch
            // 
            this.textBoxHoursSearch.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHoursSearch.Location = new System.Drawing.Point(234, 20);
            this.textBoxHoursSearch.Name = "textBoxHoursSearch";
            this.textBoxHoursSearch.Size = new System.Drawing.Size(184, 29);
            this.textBoxHoursSearch.TabIndex = 43;
            this.textBoxHoursSearch.TextChanged += new System.EventHandler(this.textBoxHoursSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Search";
            // 
            // dataGridViewHours
            // 
            this.dataGridViewHours.AllowUserToAddRows = false;
            this.dataGridViewHours.AllowUserToDeleteRows = false;
            this.dataGridViewHours.AllowUserToResizeColumns = false;
            this.dataGridViewHours.AllowUserToResizeRows = false;
            this.dataGridViewHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHours.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewHours.Location = new System.Drawing.Point(3, 63);
            this.dataGridViewHours.Name = "dataGridViewHours";
            this.dataGridViewHours.ReadOnly = true;
            this.dataGridViewHours.RowTemplate.Height = 25;
            this.dataGridViewHours.ShowCellErrors = false;
            this.dataGridViewHours.ShowCellToolTips = false;
            this.dataGridViewHours.ShowEditingIcon = false;
            this.dataGridViewHours.ShowRowErrors = false;
            this.dataGridViewHours.Size = new System.Drawing.Size(812, 428);
            this.dataGridViewHours.TabIndex = 41;
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 642);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetSalary)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerDaySalary)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox comboBoxCategoryNet;
        private TextBox textBoxSearchNet;
        private Label label1;
        private DataGridView dataGridViewNetSalary;
        private TabPage tabPage2;
        private DataGridView dataGridViewPerDaySalary;
        private ComboBox comboBoxCategoryPd;
        private TextBox textBoxSearchPd;
        private Label label2;
        private Button buttonPerDayExport;
        private Button buttonNetExport;
        private CheckBox checkBoxDateEnabledPd;
        private DateTimePicker dateTimePickerPd;
        private Label label3;
        private ComboBox comboBoxIDSearch;
        private Button buttonGenerate;
        private TextBox textBoxDisplayName;
        private TabPage tabPage3;
        private Button buttonExportHours;
        private ComboBox comboBoxHoursCategory;
        private TextBox textBoxHoursSearch;
        private Label label4;
        private DataGridView dataGridViewHours;
        private Label labelValDate;
        private Label labelValDate2;
    }
}