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
    public partial class EditReport : Form
    {
        public EditReport()
        {
            InitializeComponent();
        }

        public static string status;
        public static int index;
        private void EditReport_Load(object sender, EventArgs e)
        {
            //get data to put into form
            index = ViewDataForm.index;
            string title = LoginForm.reports[index].Title.ToString();
            string description = LoginForm.reports[index].Description.ToString();
            status = LoginForm.reports[index].Status.ToString();

            lblTitle.Text = title;
            lblDescription.Text = description;
            cmbBxStatus.SelectedItem = status;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveStatus();

            AHomePageForm Home = new AHomePageForm();
            Home.Show();
            this.Close();

            //to show that its saved
            MessageBox.Show("saved");
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveStatus();

            ViewDataForm ViewForm = new ViewDataForm();
            ViewForm.Show();
            this.Close();
            //to show that its saved
            MessageBox.Show("saved");
        }

        public void SaveStatus()
        {
            //get the changed status
            status = cmbBxStatus.SelectedItem.ToString();

            //file name ("AllReportTest.csv")
            var file = "AllReportsTest2.csv";

            using (var stream = File.CreateText(file))
            {
                for (int i = 0; i < LoginForm.reports.Count(); i++)
                {
                    if (i == index)
                    {
                        string title = LoginForm.reports[i].Title.ToString();
                        string name = LoginForm.reports[i].Name.ToString();
                        string id = LoginForm.reports[i].ID.ToString();
                        string description = "\"" + LoginForm.reports[i].Description.ToString() + "\"";
                        string urgency = LoginForm.reports[i].Priority.ToString();
                        string date = "\"" + (LoginForm.reports[i].Date).Date.ToString("dd/MM/yyyy") + "\"";
                        string stat = status;
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
    }
}
