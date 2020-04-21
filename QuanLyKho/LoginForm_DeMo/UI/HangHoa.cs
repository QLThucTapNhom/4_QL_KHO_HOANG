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
    public partial class HangHoa : Form
    {
        ConnectDatabase database = new ConnectDatabase();

        public HangHoa()
        {
            InitializeComponent();
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {

            database.LoadDataGridView(DanhMuc, "select * from dbo.SanPham");
            

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txttim.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin");
            }
            else
            {
                database.LoadDataGridView(DanhMuc, "select * from SanPham where SanPhamID = '" + txttim.Text + "'");
            }
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

        

        private void buttonAll_Click(object sender, EventArgs e)
        {
            database.LoadDataGridView(DanhMuc, "select * from dbo.SanPham");
            //LoadDataAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Chưa có thông tin để thêm");

            }
            else
            {
                database.LoadDataGridView(DanhMuc, "select * from dbo.SanPham");
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
               
                string update= " update SanPham set SanPhamID =N'" + txtid.Text + "', NhaCungCapID =N'" + txtncc.Text + "' ,TenSanPham = N'" + txtten.Text + "',Hang = N'" + txthang.Text + "',XuatXu = N'" + txtxuatxu.Text + "',MauSac = N'" + txtmau.Text + "'," +
                    "SoLuongTon = " + txtsl.Text + ",DonGiaSanPham =" + txtgia.Text + ",NgaySanXuat = '" + txtdate.Text + "',ThoiGianBaoHanh= N'" + txtbaohanh.Text + "' where SanPhamID = N'" + txtid.Text + "' ";
                database.SQLConnection(update);

                database.LoadDataGridView(DanhMuc, "select * from dbo.SanPham");
                //LoadDataAll();
                MessageBox.Show(" Sửa sản Phẩm thành công !");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string idsp = txtid.Text.Trim();
            bool check = database.Check(idsp, "select SanPhamID from SanPham  ");
          if(check==false)
          {

                
            if (txtid.Text == "")
            {
                MessageBox.Show("Chưa có thông tin để thêm");

            }
            else
            {
                //command = connection.CreateCommand();
                string insert = "insert into SanPham values(N'" + txtid.Text + "',N'" + txtncc.Text + "',N'" + txtten.Text + "',N'" + txthang.Text + "',N'" + txtxuatxu.Text + "',N'" + txtmau.Text + "'," + txtsl.Text + "," + txtgia.Text + ",'" + txtdate.Text + "',N'" + txtbaohanh.Text + "')";
                //command.ExecuteNonQuery();

                database.SQLConnection(insert);
                //LoadDataAll();
                database.LoadDataGridView(DanhMuc, "select * from dbo.SanPham");
                MessageBox.Show("Thêm sản Phẩm thành công !");

            }
          }
          else
            {
                MessageBox.Show("sản phẩm này đã tồn tại");

            }    
        }
    }
}
