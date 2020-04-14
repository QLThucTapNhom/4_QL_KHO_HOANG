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
    public partial class Login : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Do you want exit program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void check_Show_CheckedChanged(object sender, EventArgs e)
        {
            if(check_Show.Checked)
            {
                textpass.UseSystemPasswordChar = true;
            }
            else
            {
                textpass.UseSystemPasswordChar = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if ((textacc.Text == "") || (textpass.Text == ""))
            {
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");

            }
            else
            {

           
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0FP3KIB\MSSQLSERVEROK;Initial Catalog=QLKho;Integrated Security=True");
                con.Open();
                string s = "select count(*) from TaiKhoan where acc='" + textacc.Text + "'and pass='" + textpass.Text + "'";


                
                bool check = db.Check(textpass.Text.Trim(), "SELECT pass FROM dbo.TaiKhoan WHERE acc=N'"+ textacc.Text.Trim()+"'");
                if (check==true)
                {
                    
                    Menu sp = new Menu();
                    sp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản!");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
