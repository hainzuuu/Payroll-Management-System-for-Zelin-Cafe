using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLICATION_DEVELOPMENT_3
{
    public partial class empLogs : Form
    {
        public empLogs()
        {
            InitializeComponent();
        }

        private void empLogs_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            DataSet DS = c1.displayEmployeeLog();
            dataGridViewEmpLogs .DataSource = DS;
            dataGridViewEmpLogs.DataMember = "epLogs";
        }

        private void checkBoxDateEnabled_CheckedChanged(object sender, EventArgs e)
        {
            
            string date = dateTimePickerLogs.Value.ToString("yyyy-MM-dd");
            if (checkBoxDateEnabled.Checked == true)
            {
                dateTimePickerLogs.Enabled = true;
                try
                {
                    Class1 c1 = new Class1();
                    DataSet DS = c1.searchEmpLogsWithDate(date);
                    dataGridViewEmpLogs.DataSource = DS;
                    dataGridViewEmpLogs.DataMember = "eplogstime";
                }
                catch
                {

                }
                
            }
            else
            {
                dateTimePickerLogs.Enabled = false;
                Class1 c1 = new Class1();
                DataSet DS = c1.displayEmployeeLog();
                dataGridViewEmpLogs.DataSource = DS;
                dataGridViewEmpLogs.DataMember = "epLogs";
            }
        }

        private void dateTimePickerLogs_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePickerLogs.Value.ToString("yyyy-MM-dd");
            try
            {
                Class1 c1 = new Class1();
                DataSet DS = c1.searchEmpLogsWithDate(date);
                dataGridViewEmpLogs.DataSource = DS;
                dataGridViewEmpLogs.DataMember = "eplogstime";
            }
            catch
            {

            }
        }

        private void buttonExportLogs_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            c1.Export(dataGridViewEmpLogs, Login.username + "_Logs");
        }
    }
}
