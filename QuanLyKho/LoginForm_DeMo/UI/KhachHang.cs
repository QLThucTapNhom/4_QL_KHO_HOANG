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
    public partial class KhachHang : Form
    {
        ConnectDatabase data = new ConnectDatabase();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            //data.LoadDataGridView(dataGridViewKhach, "select * from KhachHang");
        }
    }
}
