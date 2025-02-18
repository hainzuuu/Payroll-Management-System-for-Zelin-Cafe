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
    public partial class empDashboard : Form
    {
        public empDashboard()
        {
            InitializeComponent();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {


            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString(); 
        }

        public void selectedButton(Button b1, Button b2, Label l1, Label l2)
        {
            b1.BackColor = Color.FromArgb(4, 83, 125);
            b1.ForeColor = Color.White;
            b1.FlatAppearance.BorderSize = 0;
            b1.Enabled = false;
            l1.Visible = true;

            b2.BackColor = Color.White;
            b2.ForeColor = Color.FromArgb(4, 83, 125);
            b2.FlatAppearance.BorderSize = 2;
            b2.Enabled = true;
            l2.Visible = false;
        }

        public void clickedIN()
        {
            //aesthetics
            labelIN.BackColor = Color.FromArgb(4, 83, 125);
            labelIN.ForeColor = Color.White;
            selectedButton(buttonIN, buttonOUT, labelIN, labelOUT);
            labelStatus.Text = "•ONLINE";

        }

        public void clickedOUT()
        {
            selectedButton(buttonOUT, buttonIN, labelOUT, labelIN);
            labelStatus.Text = "•OFFLINE";
        }

        private void buttonIN_Click(object sender, EventArgs e)
        {
            clickedIN();
            //logics
            Class1 c1 = new Class1();
            c1.timeIN();
            c1.readLate();
            c1.addActive();
            
            MessageBox.Show("You are now ACTIVE", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void buttonOUT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to TIME OUT?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                clickedOUT();
                Class1 c1 = new Class1();
                c1.timeOUT();
                c1.removeActive();
                c1.computeHours();
                c1.computeMinutes();
                c1.computeDaySalary();
                c1.computeNetSalary();
                MessageBox.Show("You are now OFFLINE", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        private void empDashboard_Load(object sender, EventArgs e)
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
                mySqlcmd.CommandText = "SELECT STATUS FROM logs WHERE EID = (SELECT ID from employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "') ORDER BY ID DESC LIMIT 1";
                MySqlRD = mySqlcmd.ExecuteReader();
                MySqlRD.Read();

                if (MySqlRD[0].ToString() == "IN")
                {
                    clickedIN();
                }
                else
                {
                    clickedOUT();
                }

                MySQLconn.Close();
            }
            
            catch
            {

            }
        }

        private void labelIN_Click(object sender, EventArgs e)
        {

        }

        private void labelOUT_Click(object sender, EventArgs e)
        {

        }
    }
}
