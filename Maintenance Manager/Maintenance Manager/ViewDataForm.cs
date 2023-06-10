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
    public partial class ViewDataForm : Form
    {
        class DataRecord
        {
            public string Title;
            public string Status;
            public int Priority;
            public DateTime Date;
        }

        public ViewDataForm()
        {
            InitializeComponent();
        }

        private void ViewDataForm_Load(object sender, EventArgs e)
        {

        }


    }
}
