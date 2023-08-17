using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintenance_Manager
{
   
    public partial class AHomePageForm : Form
    {
        //states that the user is an admin for checking
        public static bool Admin;

        public AHomePageForm()
        {
            InitializeComponent();
        }

        //called when homepafe form is loaded
        private void HomePageForm_Load(object sender, EventArgs e)
        {
            //set the display labels
            lblUsername.Text = LoginForm.UserName;
            lblID.Text = "ID: " + LoginForm.UserID;
        }

        //called when view reports button is pressed
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            //loads view reports form and closes current form
            ViewDataForm ViewForm = new ViewDataForm();
            ViewForm.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //loads login form and closes current form
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Close();
        }
    }
}
