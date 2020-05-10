namespace LoginForm_DeMo.UI
{
    partial class RPNhap
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
            this.NhapHoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetXuat = new LoginForm_DeMo.UI.DataSetXuat();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhapHoadonTableAdapter = new LoginForm_DeMo.UI.DataSetXuatTableAdapters.NhapHoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NhapHoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // NhapHoadonBindingSource
            // 
            this.NhapHoadonBindingSource.DataMember = "NhapHoadon";
            this.NhapHoadonBindingSource.DataSource = this.DataSetXuat;
            // 
            // DataSetXuat
            // 
            this.DataSetXuat.DataSetName = "DataSetXuat";
            this.DataSetXuat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NhapHoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LoginForm_DeMo.UI.Nhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(883, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // NhapHoadonTableAdapter
            // 
            this.NhapHoadonTableAdapter.ClearBeforeFill = true;
            // 
            // RPNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 535);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RPNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPNhap";
            this.Load += new System.EventHandler(this.RPNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhapHoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhapHoadonBindingSource;
        private DataSetXuat DataSetXuat;
        private DataSetXuatTableAdapters.NhapHoadonTableAdapter NhapHoadonTableAdapter;
    }
}