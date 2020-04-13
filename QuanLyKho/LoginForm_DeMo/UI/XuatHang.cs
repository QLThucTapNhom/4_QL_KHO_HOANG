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
        //SqlConnection connection;
        //SqlCommand command;
        //string str = @"Data Source = WIN10PRO\SQLEXPRESS; Initial Catalog = QLKho; Integrated Security = True";
        //SqlDataAdapter adapter = new SqlDataAdapter();

        ConnectDatabase db = new ConnectDatabase();
       
        //public void LoadHoaDon()
        //{
        //    DataTable table = new DataTable();
        //    command = connection.CreateCommand();
        //    command.CommandText = "select * from HoaDonXuat ";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);

        //    //conn.Close();
        //    LoadHD.DataSource = table;

            
        //}
        //public void LoadTimHD()
        //{
        //    DataTable table = new DataTable();
        //    command = connection.CreateCommand();
        //    command.CommandText = "select * from HoaDonXuat where IdXuat  = N'" + txthdtim.Text + "' ";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);
        //    LoadHD.DataSource = table;
        //    //conn.Close();

            
        //}
        //public void LoadChiTietHD()
        //{
        //    DataTable table = new DataTable();
        //    command = connection.CreateCommand();
        //    command.CommandText = "select * from XuatChiTiet ";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);

        //    //conn.Close();
        //    LoadCT.DataSource = table;

            
        //}
        //public void LoadTimCTHD()
        //{
        //    DataTable table = new DataTable();
        //    command = connection.CreateCommand();
        //    command.CommandText = "select * from XuatChiTiet where IdXuat = N'" + txtcttim.Text + "' OR IdXuat = N'" + txthdid.Text + "' ";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);
        //    LoadCT.DataSource = table;

            
        //}
        public XuatHang()
        {
            InitializeComponent();
        }

        private void XuatHang_Load(object sender, EventArgs e)
        {
            //connection = new SqlConnection(str);
            //connection.Open();
            //LoadChiTietHD();
            db.LoadDataGridView(LoadCT, "select * from XuatChiTiet ");
            //LoadHoaDon();
            db.LoadDataGridView(LoadHD, "select * from HoaDonXuat ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txthdtim.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin cần tìm");
            }
            else
            {
                //LoadTimHD();
                db.LoadDataGridView(LoadHD, "select * from HoaDonXuat where IdXuat  = N'" + txthdtim.Text + "' ");
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
                //LoadTimCTHD();
                db.LoadDataGridView(LoadCT, "select * from XuatChiTiet where IdXuat = N'" + txtcttim.Text + "' OR IdXuat = N'" + txthdid.Text + "' ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LoadHoaDon();
            db.LoadDataGridView(LoadHD, "select * from HoaDonXuat ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //LoadChiTietHD();
            db.LoadDataGridView(LoadCT, "select * from XuatChiTiet ");
        }

        private void LoadHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txthdtien.ReadOnly = true;
            int i;
            i = LoadHD.CurrentRow.Index;
            txthdid.Text = LoadHD.Rows[i].Cells[0].Value.ToString();
            txthdnv.Text = LoadHD.Rows[i].Cells[1].Value.ToString();
            txthddate.Text = LoadHD.Rows[i].Cells[2].Value.ToString();
            txthdtien.Text = LoadHD.Rows[i].Cells[3].Value.ToString();
        }

        private void LoadCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtctgia.ReadOnly = true;
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
                //LoadTimCTHD();
                db.LoadDataGridView(LoadCT, "select * from XuatChiTiet where IdXuat = N'" + txtcttim.Text + "' OR IdXuat = N'" + txthdid.Text + "' ");
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
                //command = connection.CreateCommand();
                string update = " update HoaDonXuat set NhanVienID  = N'" + txthdnv.Text + "',NgayHD  = '" + ngay + "' where IdXuat  = N'" + txthdid.Text + "'";
                //command.ExecuteNonQuery();

                db.SQLConnection(update);


                //LoadHoaDon();
                db.LoadDataGridView(LoadHD, "select * from HoaDonXuat ");

                MessageBox.Show(" Sửa Hóa đơn thành công !");

            }
        }

        private void txthddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonhdxoa_Click(object sender, EventArgs e)
        {
            if (txthdid.Text == "")
            {
                MessageBox.Show("Chưa Có Hóa Đơn Cần Xóa");
            }
            else
            {
                //em đã tạo 1 trigger để xóa Hóa đơn trong modul3
                /*Vì khi xóa 1 hóa đơn cần xóa các chi tiết và trả lại các giá trị cho Sản Phẩm như hàng tồn kho .*/
                //command = connection.CreateCommand();
                string del = "delete HoaDonXuat  where IdXuat = N'" + txthdid.Text + "'";
                //command.ExecuteNonQuery();

                db.SQLConnection(del);
                //LoadHoaDon();
                db.LoadDataGridView(LoadHD, "select * from HoaDonXuat ");
                //LoadChiTietHD();
                db.LoadDataGridView(LoadCT, "select * from XuatChiTiet ");
                MessageBox.Show("Xóa Hóa đơn thành công !");

            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (txtctid.Text == "")
            {
                MessageBox.Show(" Bạn Chưa Nhập ID Muốn Thêm chi tiết vào ");
            }
            else
            {

                /*Việc thêm chi tiết cũng khá quan trọng vì ta thêm chi tiết thì ta cần thêm giá tiền vào hóa đơn của nó  và update
                 lại giá trị của Hàng Tồn kho của Sản Phẩm . Vậy nên em đã tạo 1 trigger cho việc thêm chi tiết ở modul 3*/
                //command = connection.CreateCommand();
                string ins = "insert into XuatChiTiet(IdXuat,SanPhamID,SoLuong) values(N'" + txtctid.Text + "', N'" + txtctsp.Text + "', " + txtctsl.Text + ")";
                //command.ExecuteNonQuery();
                db.SQLConnection(ins);
                //LoadChiTietHD();
                db.LoadDataGridView(LoadCT, "select * from XuatChiTiet ");
                //LoadHoaDon();
                db.LoadDataGridView(LoadHD, "select * from HoaDonXuat ");
                MessageBox.Show(" Thêm Chi Tiết HD thành công !");

            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (txtctid.Text == "")
            {
                MessageBox.Show("Chưa Có Hóa Đơn Cần Xóa");
            }
            else
            {
                //em đã tạo 1 trigger để xóa Hóa đơn chi tiết trong modul 3 
                /*khi xóa chi tiết ta cần trả lại hàng tồn kho cho sản phẩm và update lại giá tiền ở hóa đơn*/
                //command = connection.CreateCommand();
                string del = "delete XuatChiTiet  where IdXuat = N'" + txtctid.Text + "' and SanPhamID = N'" + txtctsp.Text + "'";
                //command.ExecuteNonQuery();

                db.SQLConnection(del);
                //LoadChiTietHD();
                db.LoadDataGridView(LoadCT, "select * from XuatChiTiet ");
                //LoadHoaDon();
                db.LoadDataGridView(LoadHD, "select * from HoaDonXuat ");
                MessageBox.Show("Xóa Chi Tiết Hóa đơn thành công !");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtctid.Text == "")
            {
                MessageBox.Show("Chưa Có Hóa Đơn Cần Thêm");
            }
            else
            {
                string ngay = txthddate.Value.ToString("MM-dd-yyy");

                /*Vì quá trình thêm khá phức tạp khi thêm 1 hóa đơn thì phải xem số lượng kho Sản Phẩm
                 có đủ không không đủ thì thông báo và đủ thì bán và giảm số lượng tồn đi sau đó update đơn giá
                 vào Chi Tiết HD từ đó tính tổng tiền vào HD cần bán . Nên em đã tạp 1 trigger cho quá trình thêm này 
                 vào datatable của bài cho tiện trong quá trình sử dụng ở modul 3. */
                //command = connection.CreateCommand();
                string insert = "insert into HoaDonXuat(IdXuat,NgayHD,NhanVienID) values(N'"+txthdid.Text+"','" + ngay + "', N'" + txthdnv.Text + "')" +
                    "insert into XuatChiTiet(IdXuat,SanPhamID,SoLuong) values(N'" + txtctid.Text + "', N'" + txtctsp.Text + "', " + txtctsl.Text + ")";
                //command.ExecuteNonQuery();
                db.SQLConnection(insert);
                //LoadChiTietHD();
                db.LoadDataGridView(LoadCT, "select * from XuatChiTiet ");
                //LoadHoaDon();
                db.LoadDataGridView(LoadHD, "select * from HoaDonXuat ");
                MessageBox.Show(" Thêm Hóa đơn thành công !");
            }
        }

        private void btnXoaCT_Click_1(object sender, EventArgs e)
        {
            if (txtctid.Text == "")
            {
                MessageBox.Show("Chưa Có Hóa Đơn Cần Xóa");
            }
            else
            {
                //em đã tạo 1 trigger để xóa Hóa đơn chi tiết trong modul 3 
                /*khi xóa chi tiết ta cần trả lại hàng tồn kho cho sản phẩm và update lại giá tiền ở hóa đơn*/
                //command = connection.CreateCommand();
                string del = "delete XuatChiTiet  where IdXuat = N'" + txtctid.Text + "' and SanPhamID = N'" + txtctsp.Text + "'";
                //command.ExecuteNonQuery();
                db.SQLConnection(del);
                //LoadChiTietHD();
                db.LoadDataGridView(LoadCT, "select * from XuatChiTiet ");
                //LoadHoaDon();
                db.LoadDataGridView(LoadHD, "select * from HoaDonXuat ");
                MessageBox.Show("Xóa Chi Tiết Hóa đơn thành công !");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
        }
    }
}
