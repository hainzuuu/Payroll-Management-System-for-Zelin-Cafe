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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APPLICATION_DEVELOPMENT_3
{
    public partial class Employee1 : Form
    {
        public Employee1()
        {
            InitializeComponent();
        }

        private void Employee1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }


        public void clearButtonColors()
        {
            buttonDashboard.BackColor = Color.Transparent;
            buttonLogs.BackColor = Color.Transparent;
            buttonAccount.BackColor = Color.Transparent;

        }

        private void Employee1_Load(object sender, EventArgs e)
        {
            clearButtonColors();
            buttonDashboard.BackColor = Color.LightGray;

            panelMain.Controls.Clear();
            empDashboard A3 = new empDashboard();
            A3.TopLevel = false;
            panelMain.Controls.Add(A3);
            A3.Dock = DockStyle.Fill;
            A3.Show();

            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataReader MySqlRD;

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT Name FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+"'";

            MySqlRD = mySqlcmd.ExecuteReader();
            MySqlRD.Read();


            labelEmpName.Text = MySqlRD[0].ToString();

            MySQLconn.Close();




        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            clearButtonColors();
            buttonDashboard.BackColor = Color.LightGray;

            panelMain.Controls.Clear();
            empDashboard A3 = new empDashboard();
            A3.TopLevel = false;
            panelMain.Controls.Add(A3);
            A3.Dock = DockStyle.Fill;
            A3.Show();
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            clearButtonColors();
            buttonLogs.BackColor = Color.LightGray;

            panelMain.Controls.Clear();
            empLogs A3 = new empLogs();
            A3.TopLevel = false;
            panelMain.Controls.Add(A3);
            A3.Dock = DockStyle.Fill;
            A3.Show();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            clearButtonColors();
            buttonAccount.BackColor = Color.LightGray;

            panelMain.Controls.Clear();
            empAccount A3 = new empAccount();
            A3.TopLevel = false;
            panelMain.Controls.Add(A3);
            A3.Dock = DockStyle.Fill;
            A3.Show();
        }
    }
}
