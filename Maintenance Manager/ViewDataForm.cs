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
    public partial class ViewDataForm : Form
    {

        public static int index = 0;

        public static int[] workerReports;
        public ViewDataForm()
        {
            InitializeComponent();
        }

        private void ViewDataForm_Load(object sender, EventArgs e)
        {
            dataGridAReports.Rows.Add(LoginForm.reports);

            //hide the create report button if an admin
            if (AHomePageForm.Admin == true)
            {
                toolStripDropDownButton1.Visible = false;
            }

            LoginForm.ReadData();
            PopulateDataGrid();
        }

        void PopulateDataGrid()
        {
            if (AHomePageForm.Admin == true)
            {
                dataGridAReports.Rows.Clear();
                //populate the grid
                for (int i = 0; i < LoginForm.reports.Length; i++)
                {
                    //title, status, Priority, Date
                    string[] rowData = { LoginForm.reports[i].Title, LoginForm.reports[i].Status, LoginForm.reports[i].Priority.ToString(), LoginForm.reports[i].Date.ToString() };
                    dataGridAReports.Rows.Add(rowData);

                    //stop user from moving colums and resizing
                    dataGridAReports.RowHeadersVisible = false;
                    dataGridAReports.MultiSelect = false;
                    dataGridAReports.ReadOnly = true;
                    dataGridAReports.AllowUserToResizeRows = false;
                    dataGridAReports.AllowUserToResizeColumns = false;
                    dataGridAReports.AllowUserToAddRows = false;
                }
            }
            else
            //if the user isnt an admin
            {
                //clear the grid
                dataGridAReports.Rows.Clear();

                //the amount of reports the user has submitted
                int count = 0;

                //the workers id
                string userId = LoginForm.UserID;

                //populate the grid
                for (int i = 0; i < LoginForm.reports.Length; i++)
                {
                    if (LoginForm.reports[i].ID == userId)
                    {
                        //title, status, Priority, Date
                        string[] rowData = { LoginForm.reports[i].Title, LoginForm.reports[i].Status, LoginForm.reports[i].Priority.ToString(), LoginForm.reports[i].Date.ToString() };
                        dataGridAReports.Rows.Add(rowData);
                        count++;

                        // stop user from moving colums and resizing
                        dataGridAReports.RowHeadersVisible = false;
                        dataGridAReports.MultiSelect = false;
                        dataGridAReports.ReadOnly = true;
                        dataGridAReports.AllowUserToResizeRows = false;
                        dataGridAReports.AllowUserToResizeColumns = false;
                        dataGridAReports.AllowUserToAddRows = false;
                    }
                    else
                    {
                        //dont enter any rows if no id
                    }

                    
                }
                //set size of data storage
                workerReports = new int[count];


                int Counter = 0;

                //populate the worker reports array with index locations
                for (int i = 0; i < LoginForm.reports.Length; i++)
                {
                    if (LoginForm.reports[i].ID == userId)
                    {
                        workerReports[Counter] = i;
                        Counter++;
                    }
                }
            }
        }

        

        private void dataGridAReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(AHomePageForm.Admin == true)
            {
                if (e.ColumnIndex == 0)
                {
                    index = e.RowIndex;
                    OpenReportForm();
                }
            }
            else
            {

                if (e.ColumnIndex == 0)
                {
                    //get index location in file of the report
                    index = workerReports[e.RowIndex];
                    
                }
            }
            
        }

        void OpenReportForm()
        {
            EditReport EditReportForm = new EditReport();
            EditReportForm.Show();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //send to respective home page depending on user
            if (AHomePageForm.Admin == true)
            {
                AHomePageForm Home = new AHomePageForm();
                Home.Show();
                this.Close();
            }
            else
            {
                WHomePageForm Home = new WHomePageForm();
                Home.Show();
                this.Close();
            }
            
        }

        private void CreateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //send to create report page
            CreateReportForm Create = new CreateReportForm();
            Create.Show();
            this.Hide();
        }
    }
}
