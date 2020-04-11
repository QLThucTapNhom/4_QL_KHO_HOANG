using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm_DeMo.UI
{
    public partial class XuatHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source = WIN10PRO\SQLEXPRESS; Initial Catalog = QLKho; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
       
        public void LoadHoaDon()
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDonXuat ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            //conn.Close();
            LoadHD.DataSource = table;
        }
        public void LoadTimHD()
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDonXuat where IdXuat  = N'" + txthdtim.Text + "' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            LoadHD.DataSource = table;
            //conn.Close();
        }
        public void LoadChiTietHD()
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from XuatChiTiet ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            //conn.Close();
            LoadCT.DataSource = table;
        }
        public void LoadTimCTHD()
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from XuatChiTiet where IdXuat = N'" + txtcttim.Text + "' OR IdXuat = N'" + txthdid.Text + "' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            LoadCT.DataSource = table;
        }
        public XuatHang()
        {
            InitializeComponent();
        }

        private void XuatHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadChiTietHD();
            LoadHoaDon();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txthdtim.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin cần tìm");
            }
            else
            {
                LoadTimHD();
            }
        }

        private void btnTimCT_Click(object sender, EventArgs e)
        {
            if (txtcttim.Text == "")
            {
                MessageBox.Show("Bạn chủa điền thông tin cần tìm");
            }
            else
            {
                LoadTimCTHD();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadChiTietHD();
        }

        private void LoadHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = LoadHD.CurrentRow.Index;
            txthdid.Text = LoadHD.Rows[i].Cells[0].Value.ToString();
            txthdnv.Text = LoadHD.Rows[i].Cells[1].Value.ToString();
            txthddate.Text = LoadHD.Rows[i].Cells[2].Value.ToString();
            txthdtien.Text = LoadHD.Rows[i].Cells[3].Value.ToString();
        }

        private void LoadCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = LoadCT.CurrentRow.Index;
            txtctid.Text = LoadCT.Rows[i].Cells[0].Value.ToString();
            txtctsp.Text = LoadCT.Rows[i].Cells[1].Value.ToString();
            txtctsl.Text = LoadCT.Rows[i].Cells[2].Value.ToString();
            txtctgia.Text = LoadCT.Rows[i].Cells[3].Value.ToString();
        }

        private void buttonhdxem_Click(object sender, EventArgs e)
        {
            if (txthdid.Text == "")
            {
                MessageBox.Show("Chưa điền hóa đơn cần tìm");
            }
            else
            {
                LoadTimCTHD();
            }
        }

        private void buttonhdsua_Click(object sender, EventArgs e)
        {
            if (txthdid.Text == "")
            {
                MessageBox.Show("Chưa có thông tin để sửa");

            }
            else
            {
                string ngay = txthddate.Value.ToString("MM-dd-yyy");
                /*Vì tính ràng buộc nên chúng ta chỉ cho phép sửa IDNhanVien,IDKhachHang và ngày tạo hóa đơn .*/
                command = connection.CreateCommand();
                command.CommandText = " update HoaDonXuat set NhanVienID  = N'" + txthdnv.Text + "',NgayHD  = '" + ngay + "' where IdXuat  = N'" + txthdid.Text + "'";
                command.ExecuteNonQuery();
                LoadHoaDon();
                MessageBox.Show(" Sửa Hóa đơn thành công !");

            }
        }

        private void txthddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
