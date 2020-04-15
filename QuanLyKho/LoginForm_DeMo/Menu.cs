using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm_DeMo.UI;
namespace LoginForm_DeMo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhapHang cc = new NhapHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cc.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(cc);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != cc)
                    ctrl.Dispose();
            }
            cc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          NhaCC cc = new NhaCC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cc.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(cc);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != cc)
                    ctrl.Dispose();
            }
            cc.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Do you wat exit program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
/*            HangHoa a = new HangHoa();
            a.Dock = DockStyle.Fill;
            this.panelControl.Controls.Add(a);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }*/
            HangHoa hh = new HangHoa() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            hh.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(hh);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != hh)
                    ctrl.Dispose();
            }
            hh.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XuatHang hh = new XuatHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            hh.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(hh);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != hh)
                    ctrl.Dispose();
            }
            hh.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Do you wat exit program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            HuongDan hh = new HuongDan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            hh.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(hh);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != hh)
                    ctrl.Dispose();
            }
            hh.Show();
        }
    }
}
