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
    public partial class ReportNhap : Form
    {
        public ReportNhap()
        {
            InitializeComponent();
        }

        private void ReportNhap_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
