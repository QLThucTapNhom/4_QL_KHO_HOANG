namespace LoginForm_DeMo.UI
{
    partial class ThongKe
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_xuat = new System.Windows.Forms.RadioButton();
            this.rdb_nhap = new System.Windows.Forms.RadioButton();
            this.rdb_hh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Loadd = new System.Windows.Forms.DataGridView();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loadd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(796, 106);
            this.panel6.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thống Kê Hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_xuat);
            this.panel1.Controls.Add(this.rdb_nhap);
            this.panel1.Controls.Add(this.rdb_hh);
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 90);
            this.panel1.TabIndex = 62;
            // 
            // rdb_xuat
            // 
            this.rdb_xuat.AutoSize = true;
            this.rdb_xuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_xuat.Location = new System.Drawing.Point(500, 33);
            this.rdb_xuat.Name = "rdb_xuat";
            this.rdb_xuat.Size = new System.Drawing.Size(112, 21);
            this.rdb_xuat.TabIndex = 52;
            this.rdb_xuat.TabStop = true;
            this.rdb_xuat.Text = "Hàng đã xuất";
            this.rdb_xuat.UseVisualStyleBackColor = true;
            this.rdb_xuat.CheckedChanged += new System.EventHandler(this.rdb_xuat_CheckedChanged);
            // 
            // rdb_nhap
            // 
            this.rdb_nhap.AutoSize = true;
            this.rdb_nhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nhap.Location = new System.Drawing.Point(330, 33);
            this.rdb_nhap.Name = "rdb_nhap";
            this.rdb_nhap.Size = new System.Drawing.Size(115, 21);
            this.rdb_nhap.TabIndex = 51;
            this.rdb_nhap.TabStop = true;
            this.rdb_nhap.Text = "Hàng đã nhập";
            this.rdb_nhap.UseVisualStyleBackColor = true;
            this.rdb_nhap.CheckedChanged += new System.EventHandler(this.rdb_nhap_CheckedChanged);
            // 
            // rdb_hh
            // 
            this.rdb_hh.AutoSize = true;
            this.rdb_hh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_hh.Location = new System.Drawing.Point(173, 33);
            this.rdb_hh.Name = "rdb_hh";
            this.rdb_hh.Size = new System.Drawing.Size(123, 21);
            this.rdb_hh.TabIndex = 50;
            this.rdb_hh.TabStop = true;
            this.rdb_hh.Text = "Hàng Tồn Kho";
            this.rdb_hh.UseVisualStyleBackColor = true;
            this.rdb_hh.CheckedChanged += new System.EventHandler(this.rdb_hh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Loadd);
            this.groupBox1.Location = new System.Drawing.Point(0, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 243);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mặt Hàng";
            // 
            // Loadd
            // 
            this.Loadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Loadd.Location = new System.Drawing.Point(6, 19);
            this.Loadd.Name = "Loadd";
            this.Loadd.Size = new System.Drawing.Size(784, 218);
            this.Loadd.TabIndex = 0;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Loadd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_xuat;
        private System.Windows.Forms.RadioButton rdb_nhap;
        private System.Windows.Forms.RadioButton rdb_hh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Loadd;
    }
}