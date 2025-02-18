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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace APPLICATION_DEVELOPMENT_3
{
    public partial class SystemSettings : Form
    {
        public SystemSettings()
        {
            InitializeComponent();
        }


        private void SystemSettings_Load(object sender, EventArgs e)
        {
            showCalltime();
            showDeductions();
        

        }

        public void showCalltime()
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
            mySqlcmd.CommandText = "SELECT CallTime FROM settings";
            MySqlRD = mySqlcmd.ExecuteReader();
            MySqlRD.Read();

            textBoxCallTime.Text = MySqlRD[0].ToString();

            MySQLconn.Close();
        }

        public void showDeductions()
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
            mySqlcmd.CommandText = "SELECT * FROM deductions";
            MySqlRD = mySqlcmd.ExecuteReader();
            MySqlRD.Read();

            textBoxSSS.Text = MySqlRD[1].ToString();
            textBoxPhilhealth.Text = MySqlRD[2].ToString();
            textBoxPagibig.Text = MySqlRD[3].ToString();
            textBoxTax.Text = MySqlRD[4].ToString();

            MySQLconn.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonTimeSave_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 c1 = new Class1();
                c1.editSettings(textBoxCallTime.Text);
                MessageBox.Show("Settings Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Check Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTimeSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                //connect
                string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
                MySqlConnection MySQLconn = new MySqlConnection(connstring);
                MySqlCommand mySqlcmd = new MySqlCommand();

                //open
                MySQLconn.Open();

                //queries
                mySqlcmd.CommandType = CommandType.Text;
                mySqlcmd.Connection = MySQLconn;
                mySqlcmd.CommandText = "UPDATE settings SET CallTime = '"+textBoxCallTime.Text+"'";
                mySqlcmd.ExecuteNonQuery();

                MySQLconn.Close();
                MessageBox.Show("Call-Time Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }


        public string adminPassword()
        {
            string adminPassword;

            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataReader MySqlRD;

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT adminPassword FROM settings";
            MySqlRD = mySqlcmd.ExecuteReader();
            MySqlRD.Read();

            adminPassword = MySqlRD[0].ToString();

            MySQLconn.Close();

            return adminPassword;
        }

        private void buttonChangePasswordSave_Click(object sender, EventArgs e)
        {
            if (textBoxOldPassword.Text == adminPassword())
            {
                if (textBoxNewPassword.Text != "" && textBoxNewPassword.Text.Length > 3)
                {
                    if (textBoxConfirmNewPW.Text == textBoxNewPassword.Text)
                    {
                        try
                        {
                            //connect
                            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
                            MySqlConnection MySQLconn = new MySqlConnection(connstring);
                            MySqlCommand mySqlcmd = new MySqlCommand();

                            //open
                            MySQLconn.Open();

                            //queries
                            mySqlcmd.CommandType = CommandType.Text;
                            mySqlcmd.Connection = MySQLconn;
                            mySqlcmd.CommandText = "UPDATE settings SET adminPassword = '" + textBoxNewPassword.Text + "'";
                            mySqlcmd.ExecuteNonQuery();

                            MySQLconn.Close();
                            MessageBox.Show("Call-Time Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        labelValConfirmPw.Visible = true;
                    }
                }
                else
                {
                    labelValNewPW.Visible = true;
                }
            }
            else
            {
                labelValWrongPW.Visible = true;
            }
        }

        private void textBoxOldPassword_TextChanged(object sender, EventArgs e)
        {
            labelValWrongPW.Visible = false;
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxConfirmNewPW.Text != "")
            {
                if (textBoxNewPassword.Text == textBoxConfirmNewPW.Text)
                {
                    labelValNewPW.Visible = false;
                }
                else
                {
                    labelValNewPW.Visible = true;
                }
            }
            else
            {
                labelValNewPW.Visible = false;
            }
        }

        private void textBoxConfirmNewPW_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == textBoxConfirmNewPW.Text)
            {
                labelValConfirmPw.Visible = false;
            }
            else
            {
                labelValConfirmPw.Visible = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            DialogResult result = MessageBox.Show("Do you want to delete all records (Not including employee profiles)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                c1.resetlogs();
                c1.resetdaysalary();
                c1.resetnetsalary();
                c1.resetsalary();
                c1.resettotal_hours();
                c1.resettotal_minutes();

                MessageBox.Show("System has been reset", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
