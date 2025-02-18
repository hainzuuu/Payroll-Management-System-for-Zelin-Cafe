namespace APPLICATION_DEVELOPMENT_3
{
    partial class Logs
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
            this.buttonExportAccounts = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxCategoryLogs = new System.Windows.Forms.ComboBox();
            this.textBoxSearchLogs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDateEnabled = new System.Windows.Forms.CheckBox();
            this.dateTimePickerLogs = new System.Windows.Forms.DateTimePicker();
            this.buttonExportLogs = new System.Windows.Forms.Button();
            this.dataGridViewEmpLogs = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonExportAccounts);
            this.tabPage1.Controls.Add(this.comboBoxSearch);
            this.tabPage1.Controls.Add(this.textBoxSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewAccounts);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profiles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonExportAccounts
            // 
            this.buttonExportAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonExportAccounts.FlatAppearance.BorderSize = 0;
            this.buttonExportAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportAccounts.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExportAccounts.ForeColor = System.Drawing.Color.White;
            this.buttonExportAccounts.Location = new System.Drawing.Point(655, 509);
            this.buttonExportAccounts.Name = "buttonExportAccounts";
            this.buttonExportAccounts.Size = new System.Drawing.Size(157, 36);
            this.buttonExportAccounts.TabIndex = 30;
            this.buttonExportAccounts.Text = "Export";
            this.buttonExportAccounts.UseVisualStyleBackColor = false;
            this.buttonExportAccounts.Click += new System.EventHandler(this.buttonExportAccounts_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Age",
            "Gender",
            "Position"});
            this.comboBoxSearch.Location = new System.Drawing.Point(86, 19);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(142, 29);
            this.comboBoxSearch.TabIndex = 28;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(234, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(184, 29);
            this.textBoxSearch.TabIndex = 27;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.AllowUserToAddRows = false;
            this.dataGridViewAccounts.AllowUserToDeleteRows = false;
            this.dataGridViewAccounts.AllowUserToResizeColumns = false;
            this.dataGridViewAccounts.AllowUserToResizeRows = false;
            this.dataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(0, 58);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.ReadOnly = true;
            this.dataGridViewAccounts.RowTemplate.Height = 25;
            this.dataGridViewAccounts.ShowCellErrors = false;
            this.dataGridViewAccounts.ShowCellToolTips = false;
            this.dataGridViewAccounts.ShowEditingIcon = false;
            this.dataGridViewAccounts.ShowRowErrors = false;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(818, 435);
            this.dataGridViewAccounts.TabIndex = 0;
            this.dataGridViewAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccounts_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxCategoryLogs);
            this.tabPage2.Controls.Add(this.textBoxSearchLogs);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.checkBoxDateEnabled);
            this.tabPage2.Controls.Add(this.dateTimePickerLogs);
            this.tabPage2.Controls.Add(this.buttonExportLogs);
            this.tabPage2.Controls.Add(this.dataGridViewEmpLogs);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBoxCategoryLogs
            // 
            this.comboBoxCategoryLogs.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategoryLogs.FormattingEnabled = true;
            this.comboBoxCategoryLogs.Items.AddRange(new object[] {
            "EID",
            "Name",
            "Time",
            "Status",
            "timeStatus"});
            this.comboBoxCategoryLogs.Location = new System.Drawing.Point(88, 23);
            this.comboBoxCategoryLogs.Name = "comboBoxCategoryLogs";
            this.comboBoxCategoryLogs.Size = new System.Drawing.Size(142, 29);
            this.comboBoxCategoryLogs.TabIndex = 39;
            // 
            // textBoxSearchLogs
            // 
            this.textBoxSearchLogs.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearchLogs.Location = new System.Drawing.Point(236, 23);
            this.textBoxSearchLogs.Name = "textBoxSearchLogs";
            this.textBoxSearchLogs.Size = new System.Drawing.Size(184, 29);
            this.textBoxSearchLogs.TabIndex = 38;
            this.textBoxSearchLogs.TextChanged += new System.EventHandler(this.textBoxSearchLogs_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Search";
            // 
            // checkBoxDateEnabled
            // 
            this.checkBoxDateEnabled.Location = new System.Drawing.Point(471, 31);
            this.checkBoxDateEnabled.Name = "checkBoxDateEnabled";
            this.checkBoxDateEnabled.Size = new System.Drawing.Size(20, 20);
            this.checkBoxDateEnabled.TabIndex = 36;
            this.checkBoxDateEnabled.UseVisualStyleBackColor = true;
            this.checkBoxDateEnabled.CheckedChanged += new System.EventHandler(this.checkBoxDateEnabled_CheckedChanged);
            // 
            // dateTimePickerLogs
            // 
            this.dateTimePickerLogs.Enabled = false;
            this.dateTimePickerLogs.Location = new System.Drawing.Point(497, 23);
            this.dateTimePickerLogs.Name = "dateTimePickerLogs";
            this.dateTimePickerLogs.Size = new System.Drawing.Size(315, 33);
            this.dateTimePickerLogs.TabIndex = 31;
            this.dateTimePickerLogs.ValueChanged += new System.EventHandler(this.dateTimePickerLogs_ValueChanged);
            // 
            // buttonExportLogs
            // 
            this.buttonExportLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.buttonExportLogs.FlatAppearance.BorderSize = 0;
            this.buttonExportLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportLogs.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExportLogs.ForeColor = System.Drawing.Color.White;
            this.buttonExportLogs.Location = new System.Drawing.Point(655, 499);
            this.buttonExportLogs.Name = "buttonExportLogs";
            this.buttonExportLogs.Size = new System.Drawing.Size(157, 36);
            this.buttonExportLogs.TabIndex = 29;
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
            this.dataGridViewEmpLogs.Location = new System.Drawing.Point(3, 62);
            this.dataGridViewEmpLogs.Name = "dataGridViewEmpLogs";
            this.dataGridViewEmpLogs.ReadOnly = true;
            this.dataGridViewEmpLogs.RowTemplate.Height = 25;
            this.dataGridViewEmpLogs.ShowCellErrors = false;
            this.dataGridViewEmpLogs.ShowCellToolTips = false;
            this.dataGridViewEmpLogs.ShowEditingIcon = false;
            this.dataGridViewEmpLogs.ShowRowErrors = false;
            this.dataGridViewEmpLogs.Size = new System.Drawing.Size(812, 420);
            this.dataGridViewEmpLogs.TabIndex = 1;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 642);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.Logs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridViewAccounts;
        private TabPage tabPage2;
        private DataGridView dataGridViewEmpLogs;
        private Label label1;
        private Button buttonExportLogs;
        private ComboBox comboBoxSearch;
        private TextBox textBoxSearch;
        private DateTimePicker dateTimePickerLogs;
        private CheckBox checkBoxDateEnabled;
        private ComboBox comboBoxCategoryLogs;
        private TextBox textBoxSearchLogs;
        private Label label2;
        private Button buttonExportAccounts;
    }
}