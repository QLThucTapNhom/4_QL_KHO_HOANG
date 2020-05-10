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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdb_xuat = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdb_nhap = new System.Windows.Forms.RadioButton();
            this.rdb_hh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Loadd = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loadd)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.rdb_xuat);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.rdb_nhap);
            this.panel1.Controls.Add(this.rdb_hh);
            this.panel1.Location = new System.Drawing.Point(5, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 136);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(143, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 41);
            this.label3.TabIndex = 53;
            this.label3.Text = "Lựa Chọn Mặt Hàng Muốn Xem ";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton3.Location = new System.Drawing.Point(492, 92);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(112, 21);
            this.radioButton3.TabIndex = 52;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hàng đã xuất";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rdb_xuat_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(143, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 41);
            this.label2.TabIndex = 53;
            this.label2.Text = "Lựa Chọn Mặt Hàng Muốn Xem ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton2.Location = new System.Drawing.Point(322, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 21);
            this.radioButton2.TabIndex = 51;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hàng đã nhập";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rdb_nhap_CheckedChanged);
            // 
            // rdb_xuat
            // 
            this.rdb_xuat.AutoSize = true;
            this.rdb_xuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_xuat.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdb_xuat.Location = new System.Drawing.Point(492, 92);
            this.rdb_xuat.Name = "rdb_xuat";
            this.rdb_xuat.Size = new System.Drawing.Size(112, 21);
            this.rdb_xuat.TabIndex = 52;
            this.rdb_xuat.TabStop = true;
            this.rdb_xuat.Text = "Hàng đã xuất";
            this.rdb_xuat.UseVisualStyleBackColor = true;
            this.rdb_xuat.CheckedChanged += new System.EventHandler(this.rdb_xuat_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton1.Location = new System.Drawing.Point(165, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 21);
            this.radioButton1.TabIndex = 50;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hàng Tồn Kho";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rdb_hh_CheckedChanged);
            // 
            // rdb_nhap
            // 
            this.rdb_nhap.AutoSize = true;
            this.rdb_nhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nhap.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdb_nhap.Location = new System.Drawing.Point(322, 92);
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
            this.rdb_hh.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdb_hh.Location = new System.Drawing.Point(165, 92);
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
            this.groupBox1.Location = new System.Drawing.Point(5, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 289);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mặt Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Loadd
            // 
            this.Loadd.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Loadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Loadd.Location = new System.Drawing.Point(12, 19);
            this.Loadd.Name = "Loadd";
            this.Loadd.Size = new System.Drawing.Size(760, 264);
            this.Loadd.TabIndex = 0;
            this.Loadd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Loadd_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 68);
            this.panel3.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Hàng Hóa";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 509);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Loadd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_xuat;
        private System.Windows.Forms.RadioButton rdb_nhap;
        private System.Windows.Forms.RadioButton rdb_hh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Loadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}