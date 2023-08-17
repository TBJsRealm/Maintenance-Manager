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
    public partial class WHomePageForm : Form
    {
        public WHomePageForm()
        {
            InitializeComponent();
        }

        //called when the form is loaded
        private void WHomePageForm_Load(object sender, EventArgs e)
        {
            //set the display labels
            lblUsername.Text = LoginForm.UserName;
            lblID.Text = "ID: " + LoginForm.UserID;
        }

        //called when view button is pressed
        private void btnView_Click(object sender, EventArgs e)
        {
            //load view reports form and close current form
            ViewDataForm ViewForm = new ViewDataForm();
            ViewForm.Show();
            this.Close();
        }

        //called when create report is pressed
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //load create report form and close current form
            CreateReportForm CreateForm = new CreateReportForm();
            CreateForm.Show();
            this.Close();
        }

        //called when the logout button is pressed
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //load login form and close current form
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Close();
        }
    }
}
