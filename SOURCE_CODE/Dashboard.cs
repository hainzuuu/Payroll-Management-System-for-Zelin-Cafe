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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            DataSet DS1 = c1.displayActive();
            dataGridViewActive.DataSource = DS1;
            dataGridViewActive.DataMember = "active";

            DataSet DS2 = c1.displayOffline();
            dataGridViewOffline.DataSource = DS2;
            dataGridViewOffline.DataMember = "offline";


        }
    }
}
