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
    public class ConnectDatabase
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-G186E8N\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True";
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
        public void loadTextBox(TextBox tb, string strselect)
        {
            Connect();
            command = new SqlCommand(strselect, connection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                tb.Text = reader[0].ToString();
            }
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
        public void loadDatetimePicker(DateTimePicker dtp, string str)
        {
            Connect();
            command = new SqlCommand(str, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                dtp.Text = reader[0].ToString();
            }
            Disconnect();
        }



    }
}
