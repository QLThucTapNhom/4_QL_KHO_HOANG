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

namespace LoginForm_DeMo
{
    public partial class HangHoa : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source = WIN10PRO\SQLEXPRESS; Initial Catalog = QLKho; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public HangHoa()
        {
            InitializeComponent();
        }
        private void LoadDataAll()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SanPham ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            //conn.Close();
            DanhMuc.DataSource = table;
        }
        private void LoadDataSearchSP()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SanPham where SanPhamID = " + txttim.Text + "";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            //conn.Close();
            DanhMuc.DataSource = table;
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadDataAll();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = DanhMuc.CurrentRow.Index;
            txtid.Text = DanhMuc.Rows[i].Cells[0].Value.ToString();
            txtncc.Text = DanhMuc.Rows[i].Cells[1].Value.ToString();
            txtten.Text = DanhMuc.Rows[i].Cells[2].Value.ToString();
            txthang.Text = DanhMuc.Rows[i].Cells[3].Value.ToString();
            txtxuatxu.Text = DanhMuc.Rows[i].Cells[4].Value.ToString();
            txtmau.Text = DanhMuc.Rows[i].Cells[5].Value.ToString();
            txtsl.Text = DanhMuc.Rows[i].Cells[6].Value.ToString();
            txtgia.Text = DanhMuc.Rows[i].Cells[7].Value.ToString();
            txtdate.Text = DanhMuc.Rows[i].Cells[8].Value.ToString();
            txtbaohanh.Text = DanhMuc.Rows[i].Cells[9].Value.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtten.Text = "";
            txtsl.Text = "";
            txtgia.Text = "";
            txtbaohanh.Text = "";
            txtxuatxu.Text = "";
            txtmau.Text = "";
            txthang.Text = "";
            txtdate.Text = "02/04/2020";
            txtncc.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txttim.Text == "" )
            {
                MessageBox.Show("Bạn chưa điền thông tin");
            }
            else
            {

                LoadDataSearchSP();
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            LoadDataAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Chưa có thông tin để thêm");

            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from SanPham where SanPhamID = " + txtid.Text + "";
                command.ExecuteNonQuery();
                LoadDataAll();
                MessageBox.Show("Xóa sản Phẩm thành công !");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Chưa có thông tin để sửa");

            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = " update SanPham set SanPhamID =N'"+txtid.Text+"', NhaCungCapID =N'" + txtncc.Text + "' ,TenSanPham = N'" + txtten.Text + "',Hang = N'" + txthang.Text + "',XuatXu = N'" + txtxuatxu.Text + "',MauSac = N'" + txtmau.Text + "'," +
                    "SoLuongTon = " + txtsl.Text + ",DonGiaSanPham =" + txtgia.Text + ",NgaySanXuat = '" + txtdate.Text + "',ThoiGianBaoHanh= N'" + txtbaohanh.Text + "' where SanPhamID = N'" + txtid.Text + "' ";
                command.ExecuteNonQuery();
                LoadDataAll();
                MessageBox.Show(" Sửa sản Phẩm thành công !");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Chưa có thông tin để thêm");

            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "insert into SanPham values(N'" + txtid.Text + "',N'" + txtncc.Text + "',N'" + txtten.Text + "',N'" + txthang.Text + "',N'" + txtxuatxu.Text + "',N'" + txtmau.Text + "'," + txtsl.Text + "," + txtgia.Text + ",'" + txtdate.Text + "',N'" + txtbaohanh.Text + "')";
                command.ExecuteNonQuery();
                LoadDataAll();
                MessageBox.Show("Thêm sản Phẩm thành công !");

            }
        }
    }
}
