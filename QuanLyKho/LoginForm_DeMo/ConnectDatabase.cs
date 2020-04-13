using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LoginForm_DeMo
{
    class ConnectDatabase
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=; Initial Catalog = QLKho; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();


        //Mở kết nối
        void Connect()
        {
            connection = new SqlConnection(str);
            connection.Open();
        }
        // Ngắt kết nối
        void Disconnect()
        {
            connection.Close();
        }


        
        //Tải dữ liệu lên datagridview
        public void LoadDataGridView(DataGridView dt, string query)
        {
            Connect();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dt.DataSource = table;
            Disconnect();
        }

        //Thực thi thao tác với database như INSERT, UPDATE. DELETE
        public void SQLConnection(string query)
        {
            Connect();
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            Disconnect();
        }




    }
}
