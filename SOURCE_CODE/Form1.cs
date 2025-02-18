using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System.Data;
using System.DirectoryServices;

namespace APPLICATION_DEVELOPMENT_3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }


        public static string username = "";
        public static string password = "";



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



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);

            username = textBoxUsername.Text;
            password = textBoxPassword.Text;


            if (username == "admin" && password == adminPassword())
            {
                Admin1 A1 = new Admin1();
                this.Hide();
                A1.Show();
            }
            
            else
            {
                MySqlConnection conn = new MySqlConnection(@"datasource=localhost; database=payroll; uid=root; password=''");
                try
                {
                    string query = "SELECT * FROM employee_profile WHERE Username = '" + username + "' AND Password = '" + password + "'";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Employee1 E1 = new Employee1();
                        this.Hide();
                        E1.Show();
                    }
                    else
                    {
                        labelValIncorrect.Visible = true;
                    }
                }
                catch
                {
                    MessageBox.Show("error");
                }
                finally
                {
                    conn.Close();
                }


                
                

                
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}