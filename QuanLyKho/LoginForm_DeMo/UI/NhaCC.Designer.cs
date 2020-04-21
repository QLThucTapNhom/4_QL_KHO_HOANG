namespace LoginForm_DeMo.UI
{
    partial class NhaCC
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
            this.dataGridViewNCC = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.dateTimePickerHHD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTTT = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.labelSDT = new System.Windows.Forms.Label();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_tenNCC = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_maNCC = new System.Windows.Forms.TextBox();
            this.txttenNCC = new System.Windows.Forms.Label();
            this.txtmaHH = new System.Windows.Forms.Label();
            this.txtdonGia = new System.Windows.Forms.Label();
            this.txtngayLap = new System.Windows.Forms.Label();
            this.txtmaNCC = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridViewNCC);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 505);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewNCC
            // 
            this.dataGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNCC.Location = new System.Drawing.Point(1, 363);
            this.dataGridViewNCC.Name = "dataGridViewNCC";
            this.dataGridViewNCC.Size = new System.Drawing.Size(750, 142);
            this.dataGridViewNCC.TabIndex = 67;
            this.dataGridViewNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNCC_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTimKiem);
            this.panel2.Controls.Add(this.dateTimePickerHHD);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTTT);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.labelSDT);
            this.panel2.Controls.Add(this.buttonLamMoi);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.txt_tenNCC);
            this.panel2.Controls.Add(this.txt_diaChi);
            this.panel2.Controls.Add(this.txt_maNCC);
            this.panel2.Controls.Add(this.txttenNCC);
            this.panel2.Controls.Add(this.txtmaHH);
            this.panel2.Controls.Add(this.txtdonGia);
            this.panel2.Controls.Add(this.txtngayLap);
            this.panel2.Controls.Add(this.txtmaNCC);
            this.panel2.Location = new System.Drawing.Point(1, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 258);
            this.panel2.TabIndex = 66;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(575, 202);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(111, 33);
            this.buttonTimKiem.TabIndex = 100;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // dateTimePickerHHD
            // 
            this.dateTimePickerHHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHHD.Location = new System.Drawing.Point(493, 70);
            this.dateTimePickerHHD.Name = "dateTimePickerHHD";
            this.dateTimePickerHHD.Size = new System.Drawing.Size(193, 20);
            this.dateTimePickerHHD.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "Thông tin thêm";
            // 
            // txtTTT
            // 
            this.txtTTT.Location = new System.Drawing.Point(493, 111);
            this.txtTTT.Multiline = true;
            this.txtTTT.Name = "txtTTT";
            this.txtTTT.Size = new System.Drawing.Size(193, 26);
            this.txtTTT.TabIndex = 97;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(493, 22);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(193, 25);
            this.txtSDT.TabIndex = 96;
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.Location = new System.Drawing.Point(378, 31);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(106, 16);
            this.labelSDT.TabIndex = 95;
            this.labelSDT.Text = "Số Điện Thoại";
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoi.Location = new System.Drawing.Point(26, 204);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(106, 33);
            this.buttonLamMoi.TabIndex = 94;
            this.buttonLamMoi.Text = "Mới";
            this.buttonLamMoi.UseVisualStyleBackColor = false;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(381, 163);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 26);
            this.txtSearch.TabIndex = 93;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(441, 202);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(102, 33);
            this.btnxoa.TabIndex = 90;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(296, 204);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(107, 33);
            this.btnsua.TabIndex = 91;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(156, 204);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(110, 33);
            this.btnthem.TabIndex = 92;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(122, 154);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(180, 26);
            this.txt_email.TabIndex = 88;
            // 
            // txt_tenNCC
            // 
            this.txt_tenNCC.Location = new System.Drawing.Point(122, 68);
            this.txt_tenNCC.Multiline = true;
            this.txt_tenNCC.Name = "txt_tenNCC";
            this.txt_tenNCC.Size = new System.Drawing.Size(180, 25);
            this.txt_tenNCC.TabIndex = 89;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(122, 111);
            this.txt_diaChi.Multiline = true;
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(180, 26);
            this.txt_diaChi.TabIndex = 87;
            // 
            // txt_maNCC
            // 
            this.txt_maNCC.Location = new System.Drawing.Point(122, 21);
            this.txt_maNCC.Multiline = true;
            this.txt_maNCC.Name = "txt_maNCC";
            this.txt_maNCC.Size = new System.Drawing.Size(180, 26);
            this.txt_maNCC.TabIndex = 86;
            // 
            // txttenNCC
            // 
            this.txttenNCC.AutoSize = true;
            this.txttenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenNCC.Location = new System.Drawing.Point(40, 77);
            this.txttenNCC.Name = "txttenNCC";
            this.txttenNCC.Size = new System.Drawing.Size(70, 16);
            this.txttenNCC.TabIndex = 85;
            this.txttenNCC.Text = "Tên NCC";
            // 
            // txtmaHH
            // 
            this.txtmaHH.AutoSize = true;
            this.txtmaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaHH.Location = new System.Drawing.Point(46, 121);
            this.txtmaHH.Name = "txtmaHH";
            this.txtmaHH.Size = new System.Drawing.Size(57, 16);
            this.txtmaHH.TabIndex = 81;
            this.txtmaHH.Text = "Địa Chỉ";
            // 
            // txtdonGia
            // 
            this.txtdonGia.AutoSize = true;
            this.txtdonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonGia.Location = new System.Drawing.Point(378, 70);
            this.txtdonGia.Name = "txtdonGia";
            this.txtdonGia.Size = new System.Drawing.Size(108, 16);
            this.txtdonGia.TabIndex = 82;
            this.txtdonGia.Text = "Hạn Hợp đồng";
            // 
            // txtngayLap
            // 
            this.txtngayLap.AutoSize = true;
            this.txtngayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngayLap.Location = new System.Drawing.Point(46, 164);
            this.txtngayLap.Name = "txtngayLap";
            this.txtngayLap.Size = new System.Drawing.Size(47, 16);
            this.txtngayLap.TabIndex = 83;
            this.txtngayLap.Text = "Email";
            // 
            // txtmaNCC
            // 
            this.txtmaNCC.AutoSize = true;
            this.txtmaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaNCC.Location = new System.Drawing.Point(46, 31);
            this.txtmaNCC.Name = "txtmaNCC";
            this.txtmaNCC.Size = new System.Drawing.Size(64, 16);
            this.txtmaNCC.TabIndex = 84;
            this.txtmaNCC.Text = "Mã NCC";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 93);
            this.panel3.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÀ CUNG CẤP";
            // 
            // NhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 513);
            this.Controls.Add(this.panel1);
            this.Name = "NhaCC";
            this.Text = "NhaCC";
            this.Load += new System.EventHandler(this.NhaCC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewNCC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerHHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTTT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_tenNCC;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_maNCC;
        private System.Windows.Forms.Label txttenNCC;
        private System.Windows.Forms.Label txtmaHH;
        private System.Windows.Forms.Label txtdonGia;
        private System.Windows.Forms.Label txtngayLap;
        private System.Windows.Forms.Label txtmaNCC;
    }
}