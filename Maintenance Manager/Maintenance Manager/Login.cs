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
        }
        User[] users;

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
                users[i - 1] = theUser;
            }

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
                    //display next form
                    AHomePageForm Home = new AHomePageForm();
                    Home.Show();
                }
                else
                {
                    WHomePageForm Home = new WHomePageForm();
                    Home.Show();
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
    }


}
