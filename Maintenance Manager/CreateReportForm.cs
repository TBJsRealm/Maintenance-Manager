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
    public partial class CreateReportForm : Form
    {
        public CreateReportForm()
        {
            InitializeComponent();
        }
        public static int index;

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save the report
            if (txtBxDescription.Text != "" && txtBxTitle.Text != "")
            {
                SaveStatus();

                //go back to the home page
                WHomePageForm Home = new WHomePageForm();
                Home.Show();
                this.Close();

                //to show that its saved
                MessageBox.Show("saved");
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save the report
            if (txtBxDescription.Text != "" && txtBxTitle.Text != "")
            {
                SaveStatus();

                //go to view data form
                ViewDataForm ViewForm = new ViewDataForm();
                ViewForm.Show();
                this.Close();
                //to show that its saved
                MessageBox.Show("saved");
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }

        }

        private void CreateReportForm_Load(object sender, EventArgs e)
        {
            cmbBxPriority.SelectedIndex = 2;
            index = ViewDataForm.index;

        }

        public void SaveStatus()
        {
            //file name ("AllReports.csv")
            var file = "AllReports.csv";

            using (var stream = File.CreateText(file))
            {
                for (int i = 0; i < LoginForm.reports.Length + 1; i++)
                {
                    if (i == LoginForm.reports.Length)
                    {
                        string title = txtBxTitle.Text;
                        string name = LoginForm.UserName;
                        string id = LoginForm.UserID;
                        string description = "\"" + txtBxDescription.Text + "\"";
                        string urgency = (cmbBxPriority.SelectedIndex + 1).ToString();
                        string date = "\"" + DateTime.Now.ToString("dd/MM/yyyy") + "\"";
                        string stat = "Reported";
                        string csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6}", title, name, id, description, urgency, date, stat);
                        stream.WriteLine(csvRow);
                    }
                    else
                    {
                        string title = LoginForm.reports[i].Title.ToString();
                        string name = LoginForm.reports[i].Name.ToString();
                        string id = LoginForm.reports[i].ID.ToString();
                        string description = "\"" + LoginForm.reports[i].Description.ToString() + "\"";
                        string urgency = LoginForm.reports[i].Priority.ToString();
                        string date = "\"" + (LoginForm.reports[i].Date).Date.ToString("dd/MM/yyyy") + "\"";
                        string stat = LoginForm.reports[i].Status.ToString();
                        string csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6}", title, name, id, description, urgency, date, stat);
                        stream.WriteLine(csvRow);
                    }

                }
            }
        }

        private void txtBxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"')
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void txtBxTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"')
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }
    }
}
