using System;
using System.Windows.Forms;

namespace LoginForm_DeMo.UI
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        ConnectDatabase data = new ConnectDatabase();
        Login login = new Login();
        private string _tenTK = "";
        public string TenTK
        {
            get { return _tenTK; }
            set { _tenTK = value; }
        }
        private string _tenMK = "";
        public string TenMK
        {
            get { return _tenMK; }
            set { _tenMK = value; }
        }


        public void MoDK()
        {
            btnLuu.Enabled = true;
            btnDoi.Enabled = false;
            txtMKcu.Enabled = true;
            txtMKmoi.Enabled = true;
        }
        public void DongDK()
        {
            txtMKcu.Clear();
            txtMKmoi.Clear();
            btnLuu.Enabled = false;
            btnDoi.Enabled = true;            
            txtMKcu.Enabled = false;
            txtMKmoi.Enabled = false;
        }
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            DongDK();
            txtTK.Text = _tenTK;
            txtMK.Text = _tenMK;
            dateTimePicker1.Format = DateTimePickerFormat.Short;            
            //ma NV
            string str1 = "SELECT tk.NhanVienID FROM TaiKhoan tk WHERE tk.acc ='" + _tenTK + "' ";
            data.loadTextBox(txtMaNV, str1);
            //ten NV
            string str2 = "SELECT nv.HoTen FROM TaiKhoan tk, NhanVien nv WHERE tk.NhanVienID = nv.NhanVienID and tk.acc = '" + _tenTK + "'";
            data.loadTextBox(txtTenNV, str2);
            //ngay sinh
            string str3 = "SELECT nv.NgaySinh FROM TaiKhoan tk, NhanVien nv WHERE tk.NhanVienID = nv.NhanVienID and tk.acc = '" + _tenTK + "'";
            data.loadDatetimePicker(dateTimePicker1, str3);
            //gioi tinh
            string str4 = "SELECT nv.GioiTinh FROM TaiKhoan tk, NhanVien nv WHERE tk.NhanVienID = nv.NhanVienID and tk.acc = '" + _tenTK + "'";
            data.loadTextBox(txtGT, str4);
            if (txtGT.Text == "True")
            {
                txtGT.Text = "Nam";
            }
            if(txtGT.Text=="False")
            {
                txtGT.Text = "Nữ";
            }
            //chuc vu
            string str5 = "SELECT nv.ChucVu FROM TaiKhoan tk, NhanVien nv WHERE tk.NhanVienID = nv.NhanVienID and tk.acc = '" + _tenTK + "'";
            data.loadTextBox(txtChucVu, str5);
            //dia chi
            string str6 = "SELECT nv.DiaChi FROM TaiKhoan tk, NhanVien nv WHERE tk.NhanVienID = nv.NhanVienID and tk.acc = '" + _tenTK + "'";
            data.loadTextBox(txtDiaChi, str6);
            //mail
            string str7 = "SELECT nv.Email FROM TaiKhoan tk, NhanVien nv WHERE tk.NhanVienID = nv.NhanVienID and tk.acc = '" + _tenTK + "'";
            data.loadTextBox(txtMail, str7);
            //luong
            string str8 = "SELECT nv.Luong FROM TaiKhoan tk, NhanVien nv WHERE tk.NhanVienID = nv.NhanVienID and tk.acc = '" + _tenTK + "'";
            data.loadTextBox(txtLuong, str8);

            
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            string x = "SELECT tk.NhanVienID FROM TaiKhoan tk WHERE tk.acc ='"+_tenTK +"' ";
            data.SQLConnection(x);
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            MoDK();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string str1 = txtMKcu.Text.Trim();
                string str2 = txtMKmoi.Text.Trim();
                if (str1 == "" && str2 == "" && str1 != _tenMK)
                {
                    MessageBox.Show("Thông tin thay đổi không đúng !!");
                }
                else
                {
                    string temp = txtMKmoi.Text.Trim();
                    string update = "UPDATE dbo.TaiKhoan SET pass = '"+ temp +"' WHERE acc = '" + _tenTK + "'";
                    data.SQLConnection(update);
                    MessageBox.Show("Thay đổi thành công rồi nhá !!");
                    DongDK();
                }
            }
            catch
            {
                MessageBox.Show("Thay đổi không thành công :)))");
            }

        }
    }
}
