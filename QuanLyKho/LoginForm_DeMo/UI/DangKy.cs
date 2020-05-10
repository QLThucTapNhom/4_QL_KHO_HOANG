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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        ConnectDatabase db = new ConnectDatabase();

        private void buttonDK_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text.Trim();
                string pass = textBoxPass.Text.Trim();
                string confirm = textBoxConfirm.Text.Trim();
                string manv = textBoxMaNV.Text.Trim();
                bool check2 = db.Check(username, "select acc from dbo.taikhoan");

                bool check1 = db.Check(manv, "select NhanVienID from dbo.nhanvien");
                if (username.Length!=0&&pass.Length!=0&&confirm.Length!=0&&manv.Length!=0)
                {
                    if (check1==true)
                    {

                        if (check2 == false)
                        {
                            if (pass == confirm)
                            {
                                string insert = "INSERT INTO dbo.TaiKhoan ( acc, pass, NhanVienID ) " +
                                "VALUES  ( '" + username + "','" + pass + "', N'" + manv + "' )";
                                db.SQLConnection(insert);
                                DialogResult result;
                                result = MessageBox.Show("Bạn muốn đăng nhập ngay không?", "Đăng Ký Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == System.Windows.Forms.DialogResult.Yes)
                                {
                                    Login lg = new Login();
                                    lg.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhập lại không đúng!");
                            }
                            
                        }
                        else {
                            MessageBox.Show("Username đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa được xác nhận là nhân viên của chúng tôi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi, Vui lòng thử lại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn muốn thoát không?", "Đăng ký có thể chưa hoàn tất.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }

        private void check_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Show.Checked)
            {
                textBoxPass.UseSystemPasswordChar = true;
                textBoxConfirm.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = false;
                textBoxConfirm.UseSystemPasswordChar = false;
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
