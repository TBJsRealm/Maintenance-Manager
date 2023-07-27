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
    public partial class EditReport : Form
    {
        public EditReport()
        {
            InitializeComponent();
        }

        private void EditReport_Load(object sender, EventArgs e)
        {
            //get data to put into form
            int index = ViewDataForm.index;
            string title = LoginForm.reports[index].Title.ToString();
            string description = LoginForm.reports[index].Description.ToString();
            string status = LoginForm.reports[index].Status.ToString();

            lblTitle.Text = title;
            lblDescription.Text = description;
            cmbBxStatus.SelectedItem = status;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AHomePageForm Home = new AHomePageForm();
            Home.Show();
            this.Close();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDataForm ViewForm = new ViewDataForm();
            ViewForm.Show();
            this.Close();
        }
    }
}
