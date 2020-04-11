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
    public partial class ReportXuat : Form
    {
        public ReportXuat()
        {
            InitializeComponent();
        }

        private void ReportXuat_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
