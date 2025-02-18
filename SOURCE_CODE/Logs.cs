using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using MySql.Data.MySqlClient;
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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            comboBoxSearch.SelectedIndex = 0;
            comboBoxCategoryLogs.SelectedIndex = 0;
            Class1 c1 = new Class1();
            DataSet DS = c1.displayRecord();
            dataGridViewAccounts.DataSource = DS;
            dataGridViewAccounts.DataMember = "epTable";

            DS = c1.displayEmployeeLogAdmin();
            dataGridViewEmpLogs.DataSource = DS;
            dataGridViewEmpLogs.DataMember = "epLogs";


        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                try
                {
                    Class1 c1 = new Class1();
                    DataSet DS = c1.displayRecord();
                    dataGridViewAccounts.DataSource = DS;
                    dataGridViewAccounts.DataMember = "epTable";
                }
                
                catch
                {

                }
            }
            else
            {
                try
                {
                    Class1 c1 = new Class1();
                    DataSet DS = c1.searchRecord(comboBoxSearch.Text, textBoxSearch.Text);
                    dataGridViewAccounts.DataSource = DS;
                    dataGridViewAccounts.DataMember = "epRecord";
                }
                catch
                {

                }
            }

        }

        private void dataGridViewAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxEmployeeNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerLogs_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxDateEnabled.Checked == true)
            {
                if (textBoxSearchLogs.Text == "")
                {
                    try
                    {
                        string date = dateTimePickerLogs.Value.ToString("yyyy-MM-dd");
                        Class1 c1 = new Class1();
                        DataSet DS = c1.displayLogsUsingDate(date);
                        dataGridViewEmpLogs.DataSource = DS;
                        dataGridViewEmpLogs.DataMember = "logUsingDate";
                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                        string date = dateTimePickerLogs.Value.ToString("yyyy-MM-dd");
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchLogsWithDate(comboBoxCategoryLogs.Text, textBoxSearchLogs.Text, date);
                        dataGridViewEmpLogs.DataSource = DS;
                        dataGridViewEmpLogs.DataMember = "epRecord";
                    }
                    catch
                    {

                    }
                }

            }

        }

        public static bool withDate = false;

        private void checkBoxDateEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDateEnabled.Checked == true)
            {
                dateTimePickerLogs.Enabled = true;
                withDate = true;

                if (textBoxSearchLogs.Text == "")
                {
                    try
                    {
                        string date = dateTimePickerLogs.Value.ToString("yyyy-MM-dd");
                        Class1 c1 = new Class1();
                        DataSet DS = c1.displayLogsUsingDate(date);
                        dataGridViewEmpLogs.DataSource = DS;
                        dataGridViewEmpLogs.DataMember = "logUsingDate";
                    }
                    catch
                    {

                    }

                }
                else
                {
                    string date = dateTimePickerLogs.Value.ToString("yyyy-MM-dd");
                    try
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchLogsWithDate(comboBoxCategoryLogs.Text, textBoxSearchLogs.Text, date);
                        dataGridViewEmpLogs.DataSource = DS;
                        dataGridViewEmpLogs.DataMember = "epRecord";

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
            else
            {

                dateTimePickerLogs.Enabled = false;
                withDate = false;


                if (textBoxSearchLogs.Text == "")
                {
                    Class1 c1 = new Class1();
                    DataSet DS = c1.displayEmployeeLogAdmin();
                    dataGridViewEmpLogs.DataSource = DS;
                    dataGridViewEmpLogs.DataMember = "epLogs";
                }
                else
                {
                    try
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchLogs(comboBoxCategoryLogs.Text, textBoxSearchLogs.Text);
                        dataGridViewEmpLogs.DataSource = DS;
                        dataGridViewEmpLogs.DataMember = "epRecord";

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }

        }

        private void textBoxSearchLogs_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBoxSearchLogs_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxSearchLogs.Text == "")
            {
                try
                {
                    if (withDate == false)
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.displayEmployeeLogAdmin();
                        dataGridViewEmpLogs.DataSource = DS;
                        dataGridViewEmpLogs.DataMember = "epLogs";
                    }
                    else
                    {
                        if (checkBoxDateEnabled.Checked == true)
                        {
                            try
                            {
                                string date = dateTimePickerLogs.Value.ToString("yyyy-MM-dd");
                                Class1 c1 = new Class1();
                                DataSet DS = c1.displayLogsUsingDate(date);
                                dataGridViewEmpLogs.DataSource = DS;
                                dataGridViewEmpLogs.DataMember = "logUsingDate";
                            }
                            catch
                            {

                            }

                        }
                    }
                
                }

                catch
                {

                }
            }
            else
            {
                if (withDate == false)
                {
                    try
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchLogs(comboBoxCategoryLogs.Text, textBoxSearchLogs.Text);
                        dataGridViewEmpLogs.DataSource = DS;
                        dataGridViewEmpLogs.DataMember = "epRecord";

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }

                else
                {
                    string date = dateTimePickerLogs.Value.ToString("yyyy-MM-dd");
                    try
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchLogsWithDate(comboBoxCategoryLogs.Text, textBoxSearchLogs.Text, date);
                        dataGridViewEmpLogs.DataSource = DS;
                        dataGridViewEmpLogs.DataMember = "epRecord";

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
                
            }
        }

        private void buttonExportLogs_Click(object sender, EventArgs e)
        {
           Class1 c1 = new Class1();
           c1.Export(dataGridViewEmpLogs, "Employee_Logs");
        }

        private void buttonExportAccounts_Click(object sender, EventArgs e)
        {
           Class1 c1 = new Class1();
           c1.Export(dataGridViewAccounts, "Employee_Profiles");
        }
    }
}
