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

        }
    }
}
