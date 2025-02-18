using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Reflection;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Dynamic;

namespace APPLICATION_DEVELOPMENT_3
{
    internal class Class1
    {
        public void addAcount(string name, int age, string gender, string position, double salary, string username, string password)
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

            mySqlcmd.CommandText = "INSERT INTO employee_profile VALUES(" + 0 + ",'" + name + "', " + age + ", '" + gender + "', '" + position + "', " + salary + ", '" + username + "', '" + password + "')";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void editAccount(int ID, string name, int age, string gender, string position, double salary, string username, string password)
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

            mySqlcmd.CommandText = "UPDATE employee_profile SET Name = '" + name + "', Age = " + age + ", Gender = '" + gender + "', Position = '" + position + "', Salary = " + salary + ", Username = '" + username + "', Password = '" + password + "' WHERE ID = " + ID + "";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void deleteAccount(int ID)
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
            mySqlcmd.CommandText = "DELETE FROM employee_profile WHERE ID = " + ID + "";
            mySqlcmd.ExecuteNonQuery();
            MySQLconn.Close();
        }

        public DataSet displayRecord()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT ID, Name, Age, Gender, Position FROM employee_profile";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "epTable");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet searchRecord(string category, string search)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT ID, Name, Age, Gender, Position FROM employee_profile WHERE " + category + " LIKE '" + search + "%'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "epRecord");

            //close
            MySQLconn.Close();
            return DS;
        }



        public void timeIN()
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

            mySqlcmd.CommandText = "INSERT INTO logs VALUES (0, (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), (SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), CURRENT_DATE, CURRENT_TIME, 'IN', 'ON-TIME')";

            mySqlcmd.ExecuteNonQuery();
            MySQLconn.Close();


        }

        public void addActive()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();

            //open
            MySQLconn.Open();
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "INSERT INTO active VALUES (0, (Select ID from employee_profile where Username = '"+Login.username+"' AND Password = '"+Login.password+ "'), (Select Name from employee_profile where Username = '"+Login.username+"' AND Password = '"+Login.password+ "'), (SELECT timeStatus from logs where EID = (SELECT EID FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+ "') ORDER BY ID DESC LIMIT 1))";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void readLate()
        {
            try
            {
                string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
                MySqlConnection MySQLconn = new MySqlConnection(connstring);
                MySqlCommand mySqlcmd = new MySqlCommand();

                //open
                MySQLconn.Open();

                //queries
                mySqlcmd.CommandType = CommandType.Text;
                mySqlcmd.Connection = MySQLconn;
                mySqlcmd.CommandText = "UPDATE logs SET timeStatus = 'LATE' WHERE Status = 'IN' AND EID in (SELECT EID FROM logs WHERE Time > (SELECT CallTime FROM settings)) ORDER BY ID DESC LIMIT 1";
                mySqlcmd.ExecuteNonQuery();


                MySQLconn.Close();
            }

            catch
            {

            }
        }

        


        public void removeActive()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();

            //open
            MySQLconn.Open();
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "DELETE FROM active WHERE EID = (Select ID from employee_profile where Username = '" + Login.username + "' AND Password = '" + Login.password + "')";
           

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        

        public void timeOUT()
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

            mySqlcmd.CommandText = "INSERT INTO logs VALUES (0, (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), (SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), CURRENT_DATE, CURRENT_TIME, 'OUT', 'ON-TIME')";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void computeHours()
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

            mySqlcmd.CommandText = "INSERT INTO total_hours VALUES " +
                "(0, " +
                "(SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), " +
                "(SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), " +
                "CURRENT_DATE, " +
                "(SELECT TIMEDIFF ((SELECT Time FROM logs WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+"') AND Status = 'OUT' ORDER BY ID DESC LIMIT 1),(SELECT Time FROM logs WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+"') AND Status = 'IN' ORDER BY ID DESC LIMIT 1))))";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void computeMinutes()
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

            mySqlcmd.CommandText = "INSERT INTO total_minutes VALUES " +
                "(0, " +
                "(SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), " +
                "(SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), " +
                "CURRENT_DATE, " +
                "(SELECT TIME_TO_SEC((SELECT TIMEDIFF ((SELECT Time FROM logs WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+ "') AND Status = 'OUT' ORDER BY ID DESC LIMIT 1),(SELECT Time FROM logs WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+Login.username+ "' AND Password = '"+Login.password+ "') AND Status = 'IN' ORDER BY ID DESC LIMIT 1))))/60))";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public DataSet displayActive()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Status FROM active";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "active");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet displayOffline()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "Select ID, Name FROM employee_profile WHERE ID NOT IN (Select EID FROM active)";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "offline");

            //close
            MySQLconn.Close();
            return DS;
    
        }

        public DataSet displayEmployeeLog()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT Name, Date, Time, Status, timeStatus FROM logs WHERE EID = (SELECT ID from employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "')";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "epLogs");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet displayEmployeeLogAdmin()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Time, Status, timeStatus FROM logs";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "epLogs");

            //close
            MySQLconn.Close();
            return DS;
        }


        public DataSet displayActiveEmployee()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT status from logs WHERE Name in (Select Name from logs) ";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "epLogs");

            //close
            MySQLconn.Close();
            return DS;
        }

        public void editSettings(string calltime, string outtime)
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

            mySqlcmd.CommandText = "UPDATE settings SET CallTime = '"+calltime+"', OutTime = '"+outtime+"'";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void computeDaySalary()
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

            mySqlcmd.CommandText = "INSERT INTO daysalary VALUES (0, (SELECT ID FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+ "'), (SELECT Name FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+ "'), CURRENT_DATE, (SELECT (SELECT Minutes FROM total_minutes WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+ "') ORDER BY ID DESC LIMIT 1) /60 * (SELECT Salary FROM employee_profile WHERE ID = (SELECT ID FROM employee_profile WHERE Username = '" + Login.username+"' AND Password = '"+Login.password+ "'))))";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public static int month1 = DateTime.Now.Month;
        public static int day1 = DateTime.Now.Day;


        public static int month;
        public static int day;


        public void getDate()
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

            mySqlcmd.CommandText = "SELECT MONTH(CURRENT_DATE), DAY(CURRENT_DATE)";
            MySqlRD = mySqlcmd.ExecuteReader();
            MySqlRD.Read();


            month = int.Parse(MySqlRD[0].ToString());
            day = int.Parse(MySqlRD[1].ToString());
            MySQLconn.Close();
        }



        public void computeNetSalary()
        {

            getDate();
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;

            if (month == 1)
            {

                if (day >= 26)
                {
                    mySqlcmd.CommandText = "INSERT INTO netsalary VALUES(0, (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), (SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), YEAR(CURRENT_DATE), MONTHNAME(CURRENT_DATE), DAY(CURRENT_DATE), ((SELECT IFNULL(SUM(Salary), 0) FROM daysalary WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+ Login.username + "' AND Password = '"+ Login.password + "') AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) >= 26)) )";

                }
                else if (day <= 10)
                {
                    mySqlcmd.CommandText = "INSERT INTO netsalary VALUES(0, (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), (SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), YEAR(CURRENT_DATE), MONTHNAME(CURRENT_DATE), DAY(CURRENT_DATE),(SELECT IFNULL((SELECT SUM(Salary) FROM daysalary WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "') AND YEAR(Date) = YEAR(CURRENT_DATE) - 1 AND MONTH(Date) = MONTH(CURRENT_DATE) + 11 AND DAY(Date) >= 26), 0) + IFNULL((SELECT SUM(Salary) FROM daysalary WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "') AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) <= DAY(CURRENT_DATE) AND DAY(Date) <= 10), 0)))";

                }
                else if (day >= 11 && day <= 25)
                {
                    mySqlcmd.CommandText = "INSERT INTO netsalary VALUES(0, (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), (SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), YEAR(CURRENT_DATE), MONTHNAME(CURRENT_DATE), DAY(CURRENT_DATE), (SELECT IFNULL(SUM(Salary), 0) FROM daysalary WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+"') AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) >= 11 AND DAY(Date) <= 25))";

                }
 
            }
            else
            {
                if (day >= 26)
                {
                    mySqlcmd.CommandText = "INSERT INTO netsalary VALUES(0, (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), (SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), YEAR(CURRENT_DATE), MONTHNAME(CURRENT_DATE), DAY(CURRENT_DATE), ((SELECT IFNULL(SUM(Salary), 0) FROM daysalary WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+ Login.username + "' AND Password = '"+ Login.password + "') AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) >= 26)) )";
                }
                else if (day <= 10)
                {
                    mySqlcmd.CommandText = "INSERT INTO netsalary VALUES(0, (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), (SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), YEAR(CURRENT_DATE), MONTHNAME(CURRENT_DATE), DAY(CURRENT_DATE), (SELECT IFNULL((SELECT SUM(Salary) FROM daysalary WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+"') AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) - 1 AND DAY(Date) >= 26), 0) + IFNULL((SELECT SUM(Salary) FROM daysalary WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+ Login.username + "' AND Password = '"+ Login.password + "') AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) <= DAY(CURRENT_DATE)), 0)))";

                }
                else if (day >= 11 && day <= 25)
                {
                    mySqlcmd.CommandText = "INSERT INTO netsalary VALUES(0, (SELECT ID FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), (SELECT Name FROM employee_profile WHERE Username = '" + Login.username + "' AND Password = '" + Login.password + "'), YEAR(CURRENT_DATE), MONTHNAME(CURRENT_DATE), DAY(CURRENT_DATE), (SELECT IFNULL(SUM(Salary), 0) FROM daysalary WHERE EID = (SELECT ID FROM employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+"') AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) >= 11 AND DAY(Date) <= 25))";
                }
            }


            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void generateFinalSalary(int EID)
        {

            getDate();
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;

            if (month == 1)
            {

                if (day >= 26)
                {
                    mySqlcmd.CommandText = "INSERT INTO salary VALUES(0, "+EID+", (SELECT Name FROM employee_profile WHERE ID = "+EID+ "), (YEAR(CURRENT_DATE)), (SELECT CONCAT(MONTHNAME(CURRENT_DATE), ' 26 - ', MONTHNAME(CURRENT_DATE), ' ', DAY(CURRENT_DATE))), (SELECT IFNULL(SUM(Minutes / 60), 0) FROM total_minutes WHERE YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) >= 26), (SELECT IFNULL((SELECT salary FROM netsalary WHERE EID = " + EID + " ORDER BY ID DESC LIMIT 1), 0)))";

                }
                else if (day <= 10)
                {
                    mySqlcmd.CommandText = "INSERT INTO salary VALUES(0, "+EID+", (SELECT Name FROM employee_profile WHERE ID = "+EID+"), (YEAR(CURRENT_DATE)), (SELECT CONCAT(MONTHNAME(DATE_ADD(DATE_ADD(NOW(),INTERVAL -1 MONTH), INTERVAL 0 DAY)), ' 26 - ', MONTHNAME(CURRENT_DATE), ' ', DAY(CURRENT_DATE))), (SELECT IFNULL((SELECT SUM(Minutes) FROM total_minutes WHERE EID = "+EID+" AND YEAR(Date) = YEAR(CURRENT_DATE) - 1 AND MONTH(Date) = MONTH(CURRENT_DATE) + 11 AND DAY(Date) >= 26), 0) + IFNULL((SELECT SUM(Minutes) FROM total_minutes WHERE EID = "+EID+ " AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) <= DAY(CURRENT_DATE)), 0)), (SELECT IFNULL((SELECT salary FROM netsalary WHERE EID = " + EID + " ORDER BY ID DESC LIMIT 1), 0)))";
                }
                else if (day >= 11 && day <= 25)
                {
                    mySqlcmd.CommandText = "INSERT INTO salary VALUES(0, " + EID + ", (SELECT Name FROM employee_profile WHERE ID = " + EID + "), (YEAR(CURRENT_DATE)), (SELECT CONCAT(MONTHNAME(CURRENT_DATE), ' 11 - ', MONTHNAME(CURRENT_DATE), ' ', DAY(CURRENT_DATE))), (SELECT IFNULL(SUM(Minutes / 60), 0) FROM total_minutes WHERE YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) >= 11 AND DAY(Date) <= 25), (SELECT IFNULL((SELECT salary FROM netsalary WHERE EID = " + EID + " ORDER BY ID DESC LIMIT 1), 0)))";

                }

            }
            else
            {
                if (day >= 26)
                {
                    mySqlcmd.CommandText = "INSERT INTO salary VALUES(0, "+EID+", (SELECT Name FROM employee_profile WHERE ID = " + EID + "), (YEAR(CURRENT_DATE)), (SELECT CONCAT(MONTHNAME(CURRENT_DATE), ' 26 - ', MONTHNAME(CURRENT_DATE), ' ', DAY(CURRENT_DATE))), (SELECT IFNULL(SUM(Minutes / 60), 0) FROM total_minutes WHERE YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) >= 26), (SELECT IFNULL((SELECT salary FROM netsalary WHERE EID = " + EID + " ORDER BY ID DESC LIMIT 1), 0)))";
                }
                else if (day <= 10)
                {
                    mySqlcmd.CommandText = "INSERT INTO salary VALUES(0, " + EID + ", (SELECT Name FROM employee_profile WHERE ID = " + EID + "), (YEAR(CURRENT_DATE)), (SELECT CONCAT(MONTHNAME(DATE_ADD(DATE_ADD(NOW(),INTERVAL -1 MONTH), INTERVAL 0 DAY)), ' 26 - ', MONTHNAME(CURRENT_DATE), ' ', DAY(CURRENT_DATE))), (SELECT IFNULL((SELECT SUM(Minutes) FROM total_minutes WHERE EID = 3 AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) - 1 AND DAY(Date) >= 26), 0) + IFNULL((SELECT SUM(Minutes) FROM total_minutes WHERE EID = 3 AND YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) <= DAY(CURRENT_DATE)), 0)), (SELECT IFNULL((SELECT salary FROM netsalary WHERE EID = " + EID + " ORDER BY ID DESC LIMIT 1), 0)))";

                }
                else if (day >= 11 && day <= 25)
                {
                    mySqlcmd.CommandText = "INSERT INTO salary VALUES(0, " + EID + ", (SELECT Name FROM employee_profile WHERE ID = " + EID + "), (YEAR(CURRENT_DATE)), (SELECT CONCAT(MONTHNAME(CURRENT_DATE), ' 11 - ', MONTHNAME(CURRENT_DATE), ' ', DAY(CURRENT_DATE))), (SELECT IFNULL(SUM(Minutes / 60), 0) FROM total_minutes WHERE YEAR(Date) = YEAR(CURRENT_DATE) AND MONTH(Date) = MONTH(CURRENT_DATE) AND DAY(Date) >= 11 AND DAY(Date) <= 25), (SELECT IFNULL((SELECT salary FROM netsalary WHERE EID = " + EID + " ORDER BY ID DESC LIMIT 1), 0)))";
                }
            }


            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }


        public DataSet displayNetSalary()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Year, Month, Date, Salary FROM netsalary";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "NetSalary");

            //close
            MySQLconn.Close();
            return DS;
        }


        public DataSet displayPerDaySalary()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Salary FROM daysalary";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "PerDaySalary");

            //close
            MySQLconn.Close();
            return DS;
        }


        public void editSettings(string callIn)
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

            mySqlcmd.CommandText = "UPDATE employee_profile SET CallTime = '" + callIn +"' WHERE ID = 1";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public DataSet displayLogsUsingDate(string date)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Time, Status, timeStatus FROM logs WHERE Date = '"+date+"'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "logUsingDate");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet searchLogs(string category, string search)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Time, Status, timeStatus FROM logs WHERE " + category + " LIKE '" + search + "%'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "epRecord");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet searchLogsWithDate(string category, string search, string date)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Time, Status, timeStatus FROM logs WHERE " + category + " LIKE '" + search + "%' AND Date = '"+date+"'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "epRecord");

            //close
            MySQLconn.Close();
            return DS;
        }


        public DataSet fillComboboxAccount()
        {
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT ID FROM employee_profile";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "Names");

            //close
            MySQLconn.Close();


            return DS;
        }

        public DataSet searchEmpLogsWithDate(string date)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT Name, Date, Time, Status, timeStatus FROM logs WHERE EID = (Select ID from employee_profile WHERE Username = '"+Login.username+"' AND Password = '"+Login.password+"') AND Date = '"+date+"'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "eplogstime");

            //close
            MySQLconn.Close();
            return DS;
        }





        public void Export(DataGridView datagrid, string filename)
        {
            if (datagrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = filename + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It not possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(datagrid.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in datagrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in datagrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataSet searchPdWithDate(string category, string search, string date)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Salary FROM daysalary WHERE " + category + " LIKE '" + search + "%' AND Date = '" + date + "'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "PdRecord");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet searchPdOnlyDate(string date)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Salary FROM daysalary WHERE Date = '" + date + "'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "PdRecord");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet searchPdWithText(string category, string search)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Salary FROM daysalary WHERE " + category + " LIKE '" + search + "%'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "PdRecord");

            //close
            MySQLconn.Close();
            return DS;
        }
        public DataSet displayLastSalary()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Year, Date, Total_Hours, Salary FROM salary";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "last");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet displayLastSalarySearch(string category, string search)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Year, Date, Total_Hours, Salary FROM salary WHERE " + category + " LIKE '" + search + "%'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "last1");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet displayHours()
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Hours_gained AS Hours FROM total_hours";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "hours");

            //close
            MySQLconn.Close();
            return DS;
        }

        public DataSet displayHoursSearch(string category, string search)
        {
            //connect
            string connstring = "datasource=localhost; database=payroll; uid=root; password=''";
            MySqlConnection MySQLconn = new MySqlConnection(connstring);
            MySqlCommand mySqlcmd = new MySqlCommand();
            MySqlDataAdapter MySqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            //open
            MySQLconn.Open();

            //queries
            mySqlcmd.CommandType = CommandType.Text;
            mySqlcmd.Connection = MySQLconn;
            mySqlcmd.CommandText = "SELECT EID, Name, Date, Hours_gained AS Hours FROM total_hours WHERE " + category + " LIKE '" + search + "%'";

            mySqlcmd.ExecuteNonQuery();

            //get result
            MySqlDA.SelectCommand = mySqlcmd;
            MySqlDA.Fill(DS, "hours1");

            //close
            MySQLconn.Close();
            return DS;
        }



        public void resetlogs()
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

            mySqlcmd.CommandText = "DELETE FROM logs";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void resetdaysalary()
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

            mySqlcmd.CommandText = "DELETE FROM daysalary";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void resettotal_hours()
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

            mySqlcmd.CommandText = "DELETE FROM total_hours";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void resettotal_minutes()
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

            mySqlcmd.CommandText = "DELETE FROM total_minutes";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void resetnetsalary()
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

            mySqlcmd.CommandText = "DELETE FROM netsalary";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }

        public void resetsalary()
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

            mySqlcmd.CommandText = "DELETE FROM salary";

            mySqlcmd.ExecuteNonQuery();

            MySQLconn.Close();
        }






    }


}
