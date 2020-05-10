namespace LoginForm_DeMo.UI
{
    partial class RPxuat
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.XuatHoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetXuat = new LoginForm_DeMo.UI.DataSetXuat();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.XuatHoadonTableAdapter = new LoginForm_DeMo.UI.DataSetXuatTableAdapters.XuatHoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XuatHoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // XuatHoadonBindingSource
            // 
            this.XuatHoadonBindingSource.DataMember = "XuatHoadon";
            this.XuatHoadonBindingSource.DataSource = this.DataSetXuat;
            // 
            // DataSetXuat
            // 
            this.DataSetXuat.DataSetName = "DataSetXuat";
            this.DataSetXuat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.XuatHoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LoginForm_DeMo.UI.Xuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(871, 529);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // XuatHoadonTableAdapter
            // 
            this.XuatHoadonTableAdapter.ClearBeforeFill = true;
            // 
            // RPxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 553);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RPxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPxuat";
            this.Load += new System.EventHandler(this.RPxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XuatHoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource XuatHoadonBindingSource;
        private DataSetXuat DataSetXuat;
        private DataSetXuatTableAdapters.XuatHoadonTableAdapter XuatHoadonTableAdapter;
    }
}