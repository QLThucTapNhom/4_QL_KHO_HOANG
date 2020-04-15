using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm_DeMo
{
    public partial class NhaCC : Form
    {
        public NhaCC()
        {
            InitializeComponent();
        }
        ConnectDatabase database = new ConnectDatabase();

        private void NhaCC_Load(object sender, EventArgs e)
        {
            database.LoadDataGridView(dataGridViewNCC, "SELECT * FROM dbo.NhaCungCap");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string NgayHH = dateTimePickerHHD.Value.ToShortDateString();
            string maNCC = txt_maNCC.Text.TrimEnd();
            string tenNCC = txt_tenNCC.Text.TrimEnd();
            string dc = txt_diaChi.Text.TrimEnd();
            string sdt = txtSDT.Text.TrimEnd();
            string email = txt_email.Text.TrimEnd();
            string TTT = txtTTT.Text.TrimEnd();
           
            try
            {
                bool check = database.Check(txtmaNCC.Text, "SELECT NhaCungCapID FROM dbo.NhaCungCap");
                if (check == false)
                {
                    string input = "INSERT INTO dbo.NhaCungCap VALUES  ( N'" + maNCC + "' , N'" + tenNCC + "' , N'" + dc + "' ,'" + sdt + "' ,  N'" + email + "' , N'" + TTT + "' , '" + NgayHH + "')";
                    database.SQLConnection(input);
                    MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    string query = "SELECT * FROM dbo.NhaCungCap ";
                    database.LoadDataGridView(dataGridViewNCC, query);
                }
                else
                {
                    MessageBox.Show("Không thể thêm! Mã nhà cung cấp đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {


                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void DataGridViewNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dataGridViewNCC.CurrentRow.Index;
            txt_maNCC.Text = dataGridViewNCC.Rows[a].Cells[0].Value.ToString();
            txt_tenNCC.Text = dataGridViewNCC.Rows[a].Cells[1].Value.ToString();
            txt_diaChi.Text = dataGridViewNCC.Rows[a].Cells[2].Value.ToString();
            txtSDT.Text = dataGridViewNCC.Rows[a].Cells[3].Value.ToString();
            txt_email.Text = dataGridViewNCC.Rows[a].Cells[4].Value.ToString();
            txtTTT.Text = dataGridViewNCC.Rows[a].Cells[5].Value.ToString();
            dateTimePickerHHD.Text = dataGridViewNCC.Rows[a].Cells[6].Value.ToString();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            string search = "select * from NhaCungCap where NhaCungCapID LIKE '%" + txtSearch.Text + "%' OR TenNhaCungCap LIKE N'%"+ txtSearch.Text+ "%' OR SoDienThoai LIKE '%" + txtSearch.Text +"%'";
            database.SQLConnection(search);
            database.LoadDataGridView(dataGridViewNCC, search);
        }

        private void Btnsua_Click(object sender, EventArgs e)
        {
            string NgayHH = dateTimePickerHHD.Value.ToShortDateString();
            string maNCC = txt_maNCC.Text.TrimEnd();
            string tenNCC = txt_tenNCC.Text.TrimEnd();
            string dc = txt_diaChi.Text.TrimEnd();
            string sdt = txtSDT.Text.TrimEnd();
            string email = txt_email.Text.TrimEnd();
            string TTT = txtTTT.Text.TrimEnd();

            try
            {
                bool check = database.Check(maNCC, "SELECT NhaCungCapID FROM dbo.NhaCungCap");
                if (check == true)
                {
                    string input = "Update NhaCungCap SET   TenNhaCungCap = N'" + tenNCC + "' , DiaChi =N'" + dc + "' ,SoDienThoai='" + sdt + "' ,Email =  N'" + email + "' ,MoreInfo= N'" + TTT + "' ,TGHopDong = '" + NgayHH + "' WHERE NhaCungCapID ='"+ maNCC+"'";
                    database.SQLConnection(input);
                    MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    string query = "SELECT * FROM dbo.NhaCungCap ";
                    database.LoadDataGridView(dataGridViewNCC, query);
                }
                else
                {
                    MessageBox.Show("Nhà Cung cấp không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {


                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = txt_maNCC.Text.TrimEnd();
                bool check = database.Check(maNCC, "SELECT NhaCungCapID from dbo.NhaCungCap");
                if (check == true)
                {

                    string del = "EXEC dbo.DEL_NCC  @MaNCC ='"+ maNCC + "'";
                    database.SQLConnection(del);
                    MessageBox.Show("Xóa hoàn tất!");

                    string query = "SELECT * FROM dbo.NhaCungCap ";
                    database.LoadDataGridView(dataGridViewNCC, query);


                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Đã xả ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ButtonLamMoi_Click(object sender, EventArgs e)
        {
            txt_maNCC.Text = "";
            txt_tenNCC.Text = "";
            txt_diaChi.Text = "";
            txtSDT.Text = "";
            txtSearch.Text = "";
            txt_email.Text = "";
            txtTTT.Text = "";
            dateTimePickerHHD.Text = "";
        }
    }
}
