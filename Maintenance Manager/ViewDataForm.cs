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

        public ViewDataForm()
        {
            InitializeComponent();
        }

        private void ViewDataForm_Load(object sender, EventArgs e)
        {
            dataGridAReports.Rows.Add(LoginForm.reports);
            PopulateDataGrid();
        }

        void PopulateDataGrid()
        {
            dataGridAReports.Rows.Clear();
            //populate the grid
            for(int i = 0; i < LoginForm.reports.Length; i++)
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

        

        private void dataGridAReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if(e.ColumnIndex == 0)
            {
                index = e.RowIndex;
                OpenReportForm();
            }
        }

        void OpenReportForm()
        {
            EditReport EditReportForm = new EditReport();
            EditReportForm.Show();
            this.Hide();
        }
    }
}
