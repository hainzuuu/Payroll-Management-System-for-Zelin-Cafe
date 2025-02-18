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
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            DataSet DS1 = c1.fillComboboxAccount();
            comboBoxIDSearch.DataSource = DS1.Tables[0];
            comboBoxIDSearch.DisplayMember = "Names";
            comboBoxIDSearch.ValueMember = "ID";

            comboBoxCategoryPd.SelectedIndex = 0;
            comboBoxCategoryNet.SelectedIndex = 0;
            comboBoxHoursCategory.SelectedIndex = 0;

            DataSet DS = c1.displayLastSalary();
            dataGridViewNetSalary.DataSource = DS;
            dataGridViewNetSalary.DataMember = "last";

            DataSet DS2 = c1.displayPerDaySalary();
            dataGridViewPerDaySalary.DataSource = DS2;
            dataGridViewPerDaySalary.DataMember = "PerDaySalary";

            DataSet DS3 = c1.displayHours();
            dataGridViewHours.DataSource = DS3;
            dataGridViewHours.DataMember = "hours";
        }

        private void buttonNetExport_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            c1.Export(dataGridViewNetSalary, "Employee_NET");
        }

        private void buttonPerDayExport_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            c1.Export(dataGridViewPerDaySalary, "Employee_PerDay");
        }

        public static bool withDatePd = false;

        private void checkBoxDateEnabledPd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDateEnabledPd.Checked == true)
            {
                dateTimePickerPd.Enabled = true;
                withDatePd = true;

                if (textBoxSearchPd.Text == "")
                {
                    try
                    {
                        string date = dateTimePickerPd.Value.ToString("yyyy-MM-dd");
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchPdOnlyDate(date);
                        dataGridViewPerDaySalary.DataSource = DS;
                        dataGridViewPerDaySalary.DataMember = "PdRecord";
                    }
                    catch
                    {

                    }

                }
                else
                {
                    string date = dateTimePickerPd.Value.ToString("yyyy-MM-dd");
                    try
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchPdWithDate(comboBoxCategoryPd.Text, textBoxSearchPd.Text, date);
                        dataGridViewPerDaySalary.DataSource = DS;
                        dataGridViewPerDaySalary.DataMember = "PdRecord";

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
            else
            {

                dateTimePickerPd.Enabled = false;
                withDatePd = false;


                if (textBoxSearchPd.Text == "")
                {
                    Class1 c1 = new Class1();
                    DataSet DS = c1.displayPerDaySalary();
                    dataGridViewPerDaySalary.DataSource = DS;
                    dataGridViewPerDaySalary.DataMember = "PerDaySalary";
                }
                else
                {
                    try
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchPdWithText(comboBoxCategoryPd.Text, textBoxSearchPd.Text);
                        dataGridViewPerDaySalary.DataSource = DS;
                        dataGridViewPerDaySalary.DataMember = "PdRecord";

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void textBoxSearchPd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchPd.Text == "")
            {
                try
                {
                    if (withDatePd == false)
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.displayPerDaySalary();
                        dataGridViewPerDaySalary.DataSource = DS;
                        dataGridViewPerDaySalary.DataMember = "PerDaySalary";
                    }
                    else
                    {
                        if (checkBoxDateEnabledPd.Checked == true)
                        {
                            try
                            {
                                string date = dateTimePickerPd.Value.ToString("yyyy-MM-dd");
                                Class1 c1 = new Class1();
                                DataSet DS = c1.searchPdOnlyDate(date);
                                dataGridViewPerDaySalary.DataSource = DS;
                                dataGridViewPerDaySalary.DataMember = "PdRecord";
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
                if (withDatePd == false)
                {
                    try
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchPdWithText(comboBoxCategoryPd.Text, textBoxSearchPd.Text);
                        dataGridViewPerDaySalary.DataSource = DS;
                        dataGridViewPerDaySalary.DataMember = "PdRecord";

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }

                else
                {
                    string date = dateTimePickerPd.Value.ToString("yyyy-MM-dd");
                    try
                    {
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchPdWithDate(comboBoxCategoryPd.Text, textBoxSearchPd.Text, date);
                        dataGridViewPerDaySalary.DataSource = DS;
                        dataGridViewPerDaySalary.DataMember = "PdRecord";

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
        }

        private void dateTimePickerPd_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxDateEnabledPd.Checked == true)
            {
                if (textBoxSearchPd.Text == "")
                {
                    try
                    {
                        string date = dateTimePickerPd.Value.ToString("yyyy-MM-dd");
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchPdOnlyDate(date);
                        dataGridViewPerDaySalary.DataSource = DS;
                        dataGridViewPerDaySalary.DataMember = "PdRecord";
                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                        string date = dateTimePickerPd.Value.ToString("yyyy-MM-dd");
                        Class1 c1 = new Class1();
                        DataSet DS = c1.searchPdWithDate(comboBoxCategoryPd.Text, textBoxSearchPd.Text, date);
                        dataGridViewPerDaySalary.DataSource = DS;
                        dataGridViewPerDaySalary.DataMember = "PdRecord";
                    }
                    catch
                    {

                    }
                }

            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            c1.generateFinalSalary(int.Parse(comboBoxIDSearch.Text));
            MessageBox.Show("Payroll generated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet DS = c1.displayLastSalary();
            dataGridViewNetSalary.DataSource = DS;
            dataGridViewNetSalary.DataMember = "last";
        }

        private void comboBoxIDSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
                MySqlConnection MySQLconn = new MySqlConnection(connstring);
                MySqlCommand mySqlcmd = new MySqlCommand();
                MySqlDataReader MySqlRD;

                //open
                MySQLconn.Open();

                //queries
                mySqlcmd.CommandType = CommandType.Text;
                mySqlcmd.Connection = MySQLconn;
                mySqlcmd.CommandText = "SELECT Name FROM employee_profile WHERE ID = " + int.Parse(comboBoxIDSearch.Text) + "";

                MySqlRD = mySqlcmd.ExecuteReader();
                MySqlRD.Read();

                textBoxDisplayName.Text = MySqlRD[0].ToString();

                MySQLconn.Close();

            }
            catch
            {

            }
        }



        private void textBoxSearchNet_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchNet.Text == "")
            {
                try
                {
                    Class1 c1 = new Class1();
                    DataSet DS = c1.displayLastSalary();
                    dataGridViewNetSalary.DataSource = DS;
                    dataGridViewNetSalary.DataMember = "last";
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
                    DataSet DS = c1.displayLastSalarySearch(comboBoxCategoryNet.Text, textBoxSearchNet.Text);
                    dataGridViewNetSalary.DataSource = DS;
                    dataGridViewNetSalary.DataMember = "last1";
                }
                catch
                {

                }
                


            }
        }

        private void checkBoxDateEnabledNet_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxHoursSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHoursSearch.Text == "")
            {
                try
                {
                    Class1 c1 = new Class1();
                    DataSet DS = c1.displayHours();
                    dataGridViewHours.DataSource = DS;
                    dataGridViewHours.DataMember = "hours";
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
                    DataSet DS = c1.displayHoursSearch(comboBoxHoursCategory.Text, textBoxHoursSearch.Text);
                    dataGridViewHours.DataSource = DS;
                    dataGridViewHours.DataMember = "hours1";
                }
                catch
                {

                }
            }
        }

        private void comboBoxCategoryPd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategoryPd.SelectedIndex == 2)
            {
                labelValDate.Visible = true;
            }
            else
            {
                labelValDate.Visible = false;
            }
        }

        private void comboBoxHoursCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHoursCategory.SelectedIndex == 2)
            {
                labelValDate2.Visible = true;
            }
            else
            {
                labelValDate2.Visible = false;
            }
        }

        private void buttonExportHours_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            c1.Export(dataGridViewHours, "Employee_Hours");
        }
    }
}
