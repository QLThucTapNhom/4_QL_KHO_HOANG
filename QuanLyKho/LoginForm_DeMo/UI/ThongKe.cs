using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm_DeMo.UI
{
    public partial class ThongKe : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void rdb_hh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_hh.Checked == true)
            {
                database.LoadDataGridView(Loadd, "select * from dbo.SanPham");
            }
        }

        private void rdb_nhap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_nhap.Checked == true)
            {
                string a = "select ct.SanPhamID, sp.TenSanPham,sp.Hang,sp.XuatXu ,sp.MauSac ,sp.SoLuongTon , ct.SoLuong, 'Tong Tien' = ct.DonGia * ct.SoLuong, hd.NgayHD from NhapChiTiet ct, HoaDonNhap hd, SanPham sp where sp.SanPhamID = ct.SanPhamID and ct.IdNhap = hd.IdNhap";
                database.LoadDataGridView(Loadd, a);
            }
        }

        private void rdb_xuat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_xuat.Checked == true)
            {
                string b = "select ct.SanPhamID, sp.TenSanPham,sp.Hang,sp.XuatXu ,sp.MauSac ,sp.SoLuongTon ,  ct.SoLuong, 'Tong Tien' = ct.DonGia * ct.SoLuong, hd.NgayHD from XuatChiTiet ct, HoaDonXuat hd, SanPham sp where sp.SanPhamID = ct.SanPhamID and ct.IdXuat = hd.IdXuat ";
                database.LoadDataGridView(Loadd, b);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
