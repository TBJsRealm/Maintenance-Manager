using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Maintenance_Manager
{

    public partial class LoginForm : Form
    {
        public class User
        {
            public string name;
            public string password;
            public string userClass;
            public string ID;
        }
        public static User[] users;

        public class Report
        {
            public string Title;
            public string Name;
            public string ID;
            public string Description;
            public int Priority;
            public DateTime Date;
            public string Status;
        }
        public static Report[] reports;

        //user id if worker
        public static string UserID;
        public static string UserName;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Read a text file line by line.
            string[] lines = File.ReadAllLines("Logins.csv");
            users = new User[lines.Length - 1];
            for (int i = 1; i < lines.Length; i++)
            {
                string theLine = lines[i];
                string[] lineItems = theLine.Split(',');
                User theUser = new User();
                theUser.name = lineItems[0];
                theUser.password = lineItems[1];
                theUser.userClass = lineItems[2];
                theUser.ID = lineItems[3];
                users[i - 1] = theUser;
            }

            //read file
            ReadData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBxUsername.Text;
            string password = txtBxPassword.Text;
            int index = LoginVerify(username,password,users);
            
            if (index != -1)
            {
                if (users[index].userClass == "Admin")
                {
                    AHomePageForm.Admin = true;
                    //display next form
                    AHomePageForm Home = new AHomePageForm();
                    Home.Show();
                    this.Hide();
                }
                else
                {
                    AHomePageForm.Admin = false;
                    UserID = users[index].ID;
                    UserName = users[index].name;
                    WHomePageForm Home = new WHomePageForm();
                    Home.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
            
        }

        int LoginVerify(string uName, string pWord, User[] users)
        {
            //compare all usernames in system
            for(int i = 0; i < users.Length; i++)
            {
                //check if username matches
                if(users[i].name == uName)
                {
                    //check if password matches
                    if(users[i].password == pWord)
                    {
                        return i;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            //if username does not exist in system
            return -1;
        }


        public static void ReadData()
        {

            //get the reports data from file
            string[] lines = File.ReadAllLines("ALLReports.csv");
            reports = new Report[lines.Length - 1];
            for (int i = 1; i < lines.Length; i++)
            {
                string theLine = lines[i];
                string[] lineItems1 = theLine.Split('"');
                string[] lineItems2 = lineItems1[0].Split(',');
                string[] lineItems3 = lineItems1[2].Split(',');
                Report theReport = new Report();
                theReport.Title = lineItems2[0];
                theReport.Name = lineItems2[1];
                theReport.ID = lineItems2[2];
                theReport.Description = lineItems1[1];
                theReport.Priority = Convert.ToInt32(lineItems3[1]);
                theReport.Date = Convert.ToDateTime(lineItems1[3]);
                string[] status = lineItems1[4].Split(',');
                theReport.Status = status[1];
                reports[i - 1] = theReport;
            }
        }
    }


}
