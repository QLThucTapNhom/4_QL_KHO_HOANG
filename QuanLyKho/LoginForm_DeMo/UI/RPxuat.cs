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
    public partial class RPxuat : Form
    {
        private string mahd;
        public RPxuat(string id)
        {
            InitializeComponent();
            mahd = id;
        }

        private void RPxuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetXuat.XuatHoadon' table. You can move, or remove it, as needed.
            this.XuatHoadonTableAdapter.Fill(this.DataSetXuat.XuatHoadon,mahd);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
