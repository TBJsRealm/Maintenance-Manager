
namespace Maintenance_Manager
{
    partial class ViewDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridAReports = new System.Windows.Forms.DataGridView();
            this.viewDataFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewDataFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAReports
            // 
            this.dataGridAReports.AllowUserToAddRows = false;
            this.dataGridAReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridAReports.Location = new System.Drawing.Point(12, 32);
            this.dataGridAReports.Name = "dataGridAReports";
            this.dataGridAReports.RowHeadersWidth = 62;
            this.dataGridAReports.RowTemplate.Height = 28;
            this.dataGridAReports.Size = new System.Drawing.Size(434, 700);
            this.dataGridAReports.TabIndex = 0;
            this.dataGridAReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAReports_CellContentClick);
            // 
            // viewDataFormBindingSource
            // 
            this.viewDataFormBindingSource.DataSource = typeof(Maintenance_Manager.ViewDataForm);
            // 
            // viewDataFormBindingSource1
            // 
            this.viewDataFormBindingSource1.DataSource = typeof(Maintenance_Manager.ViewDataForm);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 180F;
            this.Column1.HeaderText = "Title";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 120F;
            this.Column2.HeaderText = "Status";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Priority";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 110F;
            this.Column4.HeaderText = "Date";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ViewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 744);
            this.Controls.Add(this.dataGridAReports);
            this.Name = "ViewDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDataForm";
            this.Load += new System.EventHandler(this.ViewDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataFormBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAReports;
        private System.Windows.Forms.BindingSource viewDataFormBindingSource;
        private System.Windows.Forms.BindingSource viewDataFormBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}