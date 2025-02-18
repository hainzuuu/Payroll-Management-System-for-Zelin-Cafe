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
    public partial class Admin3 : Form
    {
        public Admin3()
        {
            InitializeComponent();
        }

        public bool usernameExists()
        {
            bool doesExist;

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
                mySqlcmd.CommandText = "SELECT Username FROM employee_profile WHERE Username = '"+textBoxUsername.Text+"'";
                MySqlRD = mySqlcmd.ExecuteReader();
                MySqlRD.Read();
                MySqlRD[0].ToString();

                MySQLconn.Close();
                doesExist = true;
                return doesExist;
            }

            catch
            {
                doesExist = false;
                return doesExist;
            }

            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Validation();

            if (isValid == true)
            {
                string gender;

                if (radioButtonMale.Checked)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }

                try
                {
                    if (usernameExists() == false)
                    {
                        Class1 c1 = new Class1();
                        c1.addAcount(textBoxName.Text, int.Parse(textBoxAge.Text), gender, textBoxPosition.Text, double.Parse(textBoxPerHour.Text), textBoxUsername.Text, textBoxPassword.Text);

                        MessageBox.Show("Account Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        labelValUsernameExists.Visible = true;
                    }
                   
                }
                catch
                {

                }
            }
            
            else
            {
                MessageBox.Show("Check Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }


        public int validCount = 0;
        public bool isValid = false;

        public void Validation()
        {
            validCount = 0;

            if (textBoxName.Text == "" || textBoxName.Text.Any(char.IsDigit))
            {
                labelValName.Visible = true;
            }
            else
            {
                labelValName.Visible = false;
                validCount++; 
            }

            if (textBoxAge.Text == "" || textBoxAge.Text.Any(char.IsLetter))
            {
                labelValAge.Visible = true;
            }
            else
            {
                labelValAge.Visible = false;
                validCount++;
            }

            if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                labelValGender.Visible = true;
            }
            else
            {
                labelValGender.Visible = false;
                validCount++;
            }

            if (textBoxPosition.Text == "")
            {
                labelValPosition.Visible = true;
            }
            else
            {
                labelValPosition.Visible = false;
                validCount++;
            }

            if (textBoxPerHour.Text == "" || textBoxPerHour.Text.Any(char.IsLetter))
            {
                labelValPerHour.Visible = true;
            }
            else
            {
                labelValPerHour.Visible = false;
                validCount++;
            }

            if (textBoxUsername.Text == "")
            {
                labelValUsername.Visible = true;
            }
            else
            {
                labelValUsername.Visible = false;
                validCount++;
            }

            if (textBoxPassword.Text == "")
            {
                labelValPassword.Visible = true;
            }
            else
            {
                labelValPassword.Visible = false;
                validCount++;
            }

            if (textBoxPassword.Text != textBoxConfirmPW.Text)
            {
                labelValConfirmPassword.Visible = true;
            }
            else
            {
                labelValConfirmPassword.Visible = false;
                validCount++;
            }

            if (textBoxPassword.Text.Length < 4)
            {
                labelValPassword.Visible = true;
            }
            else
            {
                labelValPassword.Visible = false;
                validCount++;
            }

            if (validCount == 9)
            {
                isValid = true;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            labelValName.Visible = false;
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            labelValAge.Visible = false;
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            labelValGender.Visible = false;
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            labelValGender.Visible = false;
        }

        private void textBoxPosition_TextChanged(object sender, EventArgs e)
        {
            labelValPosition.Visible = false;
        }

        private void textBoxPerHour_TextChanged(object sender, EventArgs e)
        {
            labelValPerHour.Visible = false;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            labelValUsername.Visible = false;
            labelValUsernameExists.Visible = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelValPassword.Visible = false;
            if (textBoxConfirmPW.Text != textBoxPassword.Text)
            {
                if (textBoxConfirmPW.Text != "")
                {
                    labelValConfirmPassword.Visible = true;

                }
                
            }
            else
            {
                labelValConfirmPassword.Visible = false;
            }
        }

        private void textBoxConfirmPW_TextChanged(object sender, EventArgs e)
        {
            if (textBoxConfirmPW.Text != textBoxPassword.Text)
            {
                labelValConfirmPassword.Visible = true;
            }
            else
            {
                labelValConfirmPassword.Visible = false;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (checkBoxSearchEnabled.Checked == true)
            {
                Validation();
                if (comboBoxIDSearch.Text == "" || comboBoxIDSearch.Text.Any(char.IsLetter))
                {
                    isValid = false;
                    labelValID.Visible = true;
                }

                if (isValid == true)
                {
                    string gender;

                    if (radioButtonMale.Checked)
                    {
                        gender = "male";
                    }
                    else
                    {
                        gender = "female";
                    }

                    try
                    {
                        Class1 c1 = new Class1();
                        c1.editAccount(int.Parse(comboBoxIDSearch.Text), textBoxName.Text, int.Parse(textBoxAge.Text), gender, textBoxPosition.Text, double.Parse(textBoxPerHour.Text), textBoxUsername.Text, textBoxPassword.Text);

                        MessageBox.Show("Account Edited", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {

                    }
                }

                else
                {
                    MessageBox.Show("Check Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            {
                MessageBox.Show("Check the Checkbox Above first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (checkBoxSearchEnabled.Checked == true)
            {
                DialogResult result = MessageBox.Show("Do you want to delete account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (comboBoxIDSearch.Text != "" || comboBoxIDSearch.Text.All(char.IsDigit))
                    {

                        try
                        {
                            Class1 c1 = new Class1();
                            c1.deleteAccount(int.Parse(comboBoxIDSearch.Text));

                            MessageBox.Show("Account Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            labelValID.Visible = true;
                            MessageBox.Show("Check Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        labelValID.Visible = true;
                        MessageBox.Show("Check Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
            else
            {
                MessageBox.Show("Check the Checkbox Above first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

  

        public void Clear()
        {
            textBoxName.Text = "";
            textBoxAge.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxPosition.Text = "";
            textBoxPerHour.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPW.Text = "";
        }

        private void Admin3_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            DataSet DS = c1.fillComboboxAccount();
            comboBoxIDSearch.DataSource = DS.Tables[0];
            comboBoxIDSearch.DisplayMember = "Names";
            comboBoxIDSearch.ValueMember = "ID";
        }

        private void checkBoxSearchEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSearchEnabled.Checked == true)
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
                comboBoxIDSearch.Enabled = true;

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
                    mySqlcmd.CommandText = "SELECT * FROM employee_profile WHERE ID = " + int.Parse(comboBoxIDSearch.Text) + "";

                    MySqlRD = mySqlcmd.ExecuteReader();
                    MySqlRD.Read();

                    textBoxName.Text = MySqlRD[1].ToString();
                    textBoxAge.Text = MySqlRD[2].ToString();
                    if (MySqlRD[3].ToString() == "male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else
                    {
                        radioButtonFemale.Checked = true;
                    }
                    textBoxPosition.Text = MySqlRD[4].ToString();
                    textBoxPerHour.Text = MySqlRD[5].ToString();
                    textBoxUsername.Text = MySqlRD[6].ToString();
                    textBoxPassword.Text = MySqlRD[7].ToString();
                    textBoxConfirmPW.Text = MySqlRD[7].ToString();
                    MySQLconn.Close();

                }
                catch
                {

                }
            }
            else
            {
                buttonAdd.Enabled = true;
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
                comboBoxIDSearch.Enabled = false;
                Clear();
            }
            
        }

        private void comboBoxIDSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            labelValID.Visible = false;

            if (checkBoxSearchEnabled.Checked == true)
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
                    mySqlcmd.CommandText = "SELECT * FROM employee_profile WHERE ID = " + int.Parse(comboBoxIDSearch.Text) + "";

                    MySqlRD = mySqlcmd.ExecuteReader();
                    MySqlRD.Read();

                    textBoxName.Text = MySqlRD[1].ToString();
                    textBoxAge.Text = MySqlRD[2].ToString();
                    if (MySqlRD[3].ToString() == "male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else
                    {
                        radioButtonFemale.Checked = true;
                    }
                    textBoxPosition.Text = MySqlRD[4].ToString();
                    textBoxPerHour.Text = MySqlRD[5].ToString();
                    textBoxUsername.Text = MySqlRD[6].ToString();
                    textBoxPassword.Text = MySqlRD[7].ToString();
                    textBoxConfirmPW.Text = MySqlRD[7].ToString();
                    MySQLconn.Close();

                }
                catch
                {

                }
            }
            
            else
            {
                Clear();
            }

        }
    }
}
