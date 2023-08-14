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

        private void WHomePageForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = LoginForm.UserName;
            lblID.Text = "ID: " + LoginForm.UserID;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewDataForm ViewForm = new ViewDataForm();
            ViewForm.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateReportForm CreateForm = new CreateReportForm();
            CreateForm.Show();
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
