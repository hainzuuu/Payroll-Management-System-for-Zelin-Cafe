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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void Admin1_Load(object sender, EventArgs e)
        {
            clearButtonColors();
            buttonDashboard.BackColor = Color.LightGray;

            panelMain.Controls.Clear();
            Dashboard A3 = new Dashboard();
            A3.TopLevel = false;
            panelMain.Controls.Add(A3);
            A3.Dock = DockStyle.Fill;
            A3.Show();
        }

        private void Admin1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login L1 = new Login();
            this.Hide();
            L1.Show();
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            clearButtonColors();
            buttonAccounts.BackColor = Color.LightGray;

            panelMain.Controls.Clear();
            Admin3 A3 = new Admin3();
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
            Logs A3 = new Logs();
            A3.TopLevel = false;
            panelMain.Controls.Add(A3);
            A3.Dock = DockStyle.Fill;
            A3.Show();
        }

        public void clearButtonColors()
        {
            buttonDashboard.BackColor = Color.Transparent;
            buttonAccounts.BackColor = Color.Transparent;
            buttonLogs.BackColor = Color.Transparent;
            buttonPayroll.BackColor = Color.Transparent;
            buttonSystem.BackColor = Color.Transparent;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            clearButtonColors();
            buttonDashboard.BackColor = Color.LightGray;

            panelMain.Controls.Clear();
            Dashboard A3 = new Dashboard();
            A3.TopLevel = false;
            panelMain.Controls.Add(A3);
            A3.Dock = DockStyle.Fill;
            A3.Show();

        }

        private void buttonPayroll_Click(object sender, EventArgs e)
        {
            clearButtonColors();
            buttonPayroll.BackColor = Color.LightGray;

            panelMain.Controls.Clear();
            Payroll A3 = new Payroll();
            A3.TopLevel = false;
            panelMain.Controls.Add(A3);
            A3.Dock = DockStyle.Fill;
            A3.Show();
        }



        private void buttonSystem_Click(object sender, EventArgs e)
        {
            clearButtonColors();
            buttonSystem.BackColor = Color.LightGray;
            panelMain.Controls.Clear();
            SystemSettings A3 = new SystemSettings();
            A3.TopLevel = false;
            panelMain.Controls.Add(A3);
            A3.Dock = DockStyle.Fill;
            A3.Show();

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
