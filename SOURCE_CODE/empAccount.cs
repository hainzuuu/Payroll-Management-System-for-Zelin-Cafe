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
    public partial class empAccount : Form
    {
        public empAccount()
        {
            InitializeComponent();
        }

        public string empPassword()
        {
            string empPassword;

            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataReader MySqlRD;

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT Password FROM employee_profile WHERE Username = '"+Login.username+"'";
            MySqlRD = mySqlcmd.ExecuteReader();
            MySqlRD.Read();

            empPassword = MySqlRD[0].ToString();

            MySQLconn.Close();

            return empPassword;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxOldPassword.Text == empPassword())
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
                            mySqlcmd.CommandText = "UPDATE employee_profile SET Password = '" + textBoxNewPassword.Text + "' WHERE Username = '"+Login.username+"'";
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
    }
}
