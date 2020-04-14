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
    public partial class NhapHang : Form
    {
        //SqlConnection connection;
        //SqlCommand command;
        //string str = @"Data Source = WIN10PRO\SQLEXPRESS; Initial Catalog = QLKho; Integrated Security = True";
        //SqlDataAdapter adapter = new SqlDataAdapter();


        ConnectDatabase database = new ConnectDatabase();

        //public void LoadHoaDon()
        //{
        //    DataTable table = new DataTable();
        //    command = connection.CreateCommand();
        //    command.CommandText = "select * from HoaDonNhap  ";
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
        //    command.CommandText = "select * from HoaDonNhap  where IdNhap   = N'" + txthdtim.Text + "' ";
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
        //    command.CommandText = "select * from NhapChiTiet ";
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
        //    command.CommandText = "select * from NhapChiTiet where IdNhap = N'" + txtcttim.Text + "' OR IdNhap = N'" + txthdid.Text + "' ";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);
        //    LoadCT.DataSource = table;
            
            
        //}
        public NhapHang()
        {
            InitializeComponent();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            //connection = new SqlConnection(str);
            //connection.Open();
            //LoadChiTietHD();
            database.LoadDataGridView(LoadCT, "select * from NhapChiTiet ");
            //LoadHoaDon();
            database.LoadDataGridView(LoadHD, "select * from HoaDonNhap");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            database.LoadDataGridView(LoadHD, "select * from HoaDonNhap ");
            //LoadHoaDon();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            database.LoadDataGridView(LoadCT, "select * from NhapChiTiet ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txthdtim.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin cần tìm");
            }
            else
            {
                database.LoadDataGridView(LoadHD, "select * from HoaDonNhap  where IdNhap   = N'" + txthdtim.Text + "' ");
                //LoadTimHD();
            }
        }

        private void btnTimCT_Click(object sender, EventArgs e)
        {
            if (txtcttim.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin cần tìm!");
            }
            else
            {
                database.LoadDataGridView(LoadCT, "select * from NhapChiTiet where IdNhap = N'" + txtcttim.Text + "' OR IdNhap = N'" + txthdid.Text + "' ");
            }
        }

        private void buttonhdxem_Click(object sender, EventArgs e)
        {
            if (txthdid.Text == "")
            {
                MessageBox.Show("Chưa điền hóa đơn cần tìm");
            }
            else
            {
                database.LoadDataGridView(LoadCT, "select * from NhapChiTiet where IdNhap = N'" + txtcttim.Text + "' OR IdNhap = N'" + txthdid.Text + "' ");
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
                string update = " update HoaDonNhap set NhanVienID  = N'" + txthdnv.Text + "',NgayHD  = '" + ngay + "' where IdNhap  = N'" + txthdid.Text + "'";
                //command.ExecuteNonQuery();
                //LoadHoaDon();
                database.SQLConnection(update);

                database.LoadDataGridView(LoadHD, "select * from HoaDonNhap");
                MessageBox.Show(" Sửa Hóa đơn thành công !");

            }
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
                string delete = "delete HoaDonNhap where IdNhap = N'" + txthdid.Text + "'";
                //command.ExecuteNonQuery();

                database.SQLConnection(delete);



                //LoadHoaDon();
                database.LoadDataGridView(LoadHD, "select * from HoaDonNhap");
                //LoadChiTietHD();
                database.LoadDataGridView(LoadCT, "select * from NhapChiTiet ");
                MessageBox.Show("Xóa Hóa đơn thành công !");

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
                string delete = "delete NhapChiTiet   where IdNhap = N'" + txtctid.Text + "' and SanPhamID = N'" + txtctsp.Text + "'";
                //command.ExecuteNonQuery();
                //LoadChiTietHD();
                database.LoadDataGridView(LoadCT, "select * from NhapChiTiet ");

                database.SQLConnection(delete);


                //LoadHoaDon();
                database.LoadDataGridView(LoadHD, "select * from HoaDonNhap");
                MessageBox.Show("Xóa Chi Tiết Hóa đơn thành công !");

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
                string insert = "insert into NhapChiTiet(IdNhap,SanPhamID,SoLuong) values(N'" + txtctid.Text + "', N'" + txtctsp.Text + "', " + txtctsl.Text + ")";
                //command.ExecuteNonQuery();
                database.SQLConnection(insert);
                //LoadChiTietHD();
                database.LoadDataGridView(LoadCT, "select * from NhapChiTiet ");


                //LoadHoaDon();
                database.LoadDataGridView(LoadHD, "select * from HoaDonNhap");
                MessageBox.Show(" Thêm Chi Tiết HD thành công !");

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
                string insert = "insert into HoaDonNhap(IdNhap,NgayHD,NhanVienID) values(N'" + txthdid.Text + "','" + ngay + "', N'" + txthdnv.Text + "')" +
                    "insert into NhapChiTiet (IdNhap,SanPhamID,SoLuong) values(N'" + txtctid.Text + "', N'" + txtctsp.Text + "', " + txtctsl.Text + ")";
                //command.ExecuteNonQuery();
                database.SQLConnection(insert);
                //LoadChiTietHD();
                database.LoadDataGridView(LoadCT, "select * from NhapChiTiet ");
                //LoadHoaDon();
                database.LoadDataGridView(LoadHD, "select * from HoaDonNhap");
                MessageBox.Show(" Thêm Hóa đơn thành công !");
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }
    }
}
