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
        SqlDataReader sqldatareader;
        SqlConnection connection;
        SqlCommand command;
<<<<<<< HEAD
        string str = @"Data Source=DESKTOP-0FP3KIB\MSSQLSERVEROK;Initial Catalog=QLKho;Integrated Security=True";
=======
        string str = @"Data Source=WIN10PRO\SQLEXPRESS; Initial Catalog = QLKho; Integrated Security = True";
>>>>>>> 1b0a32c9fc662ed765a5b6c57b256cb5e4f5e5a3
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataReader reader;


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
        //Kiểm tra dữ liệu đã tồn tại trong database hay chưa
        public bool Check(string temp, string strsql)
        {

            Connect();
            bool check = false;
            command = new SqlCommand(strsql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString().Trim().ToLower() == temp.ToLower())
                    check = true;
            }
            Disconnect();
            return check;
        }

        public bool Check(string temp, string strsql)
        {

            Connect();
            bool check = false;
            command = new SqlCommand(strsql, connection);
            sqldatareader = command.ExecuteReader();
            while (sqldatareader.Read())
            {
                if (sqldatareader[0].ToString().Trim() == temp)
                    check = true;
            }
            Disconnect();
            return check;
        }


    }
}
