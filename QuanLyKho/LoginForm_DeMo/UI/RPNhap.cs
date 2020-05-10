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
    public partial class RPNhap : Form
    {
        private string Mahd;
        public RPNhap(string ID)
        {
            InitializeComponent();
            Mahd = ID;
        }
        

        private void RPNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetXuat.NhapHoadon' table. You can move, or remove it, as needed.
            this.NhapHoadonTableAdapter.Fill(this.DataSetXuat.NhapHoadon,Mahd);

            this.reportViewer1.RefreshReport();
        }


    }
}
