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


        private void btnViewReports_Click(object sender, EventArgs e)
        {
            ViewDataForm ViewForm = new ViewDataForm();
            ViewForm.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Close();
        }
    }
}
