using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;

namespace Tableware01
{
    public static class DataBase
    {
        private static SqlConnection connection = new SqlConnection(
            @"Data Source=DESKTOP-DU3CPSG\Q;Initial Catalog=Tableware;Integrated Security=True");
        internal static SqlConnection Connection
        {
            get { return connection; }
            set => connection = value;
        }

        /// <summary>
        /// Server connect.
        /// </summary>
        public static bool IsConnect
        {
            get
            {
                var sqlAdapter = new SqlDataAdapter();
                sqlAdapter.SelectCommand = new SqlCommand("select @@servername", Connection);
                var table = new DataTable();
                sqlAdapter.Fill(table);
                return table.Rows.Count == 1;
            }
        }

        /// <summary>
        /// Matching search in Data Base 
        /// </summary>
        public static bool TrySelect(string query)
        {
            using (var sqlAdapter = new SqlDataAdapter())
            {
                sqlAdapter.SelectCommand = new SqlCommand(query, Connection);
                var table = new DataTable();
                sqlAdapter.Fill(table);
                return table.Rows.Count == 1;
            }
        }

        /// <summary>
        /// Query with void return value
        /// </summary>
        public static void VoidQuery(string query)
        {
            Connection.Open();
            new SqlCommand(query, Connection).ExecuteNonQuery();
            Connection.Close();
        }

        public static (List<string[]> data, string[] headers) GetTable(string query, params string[] headers)
        {
            if (headers.Length == 0)
                throw new IndexOutOfRangeException();
            Connection.Open();
            using (var reader = new SqlCommand(query, Connection).ExecuteReader())
            {
                var data = new List<string[]>();
                while (reader.Read())
                {
                    var counter = 0;
                    data.Add(new string[headers.Length]
                        .Select(element => 
                        element = reader[counter++].ToString()
                                                   .Replace(" ",""))
                        .ToArray());
                }
                reader.Close();
                Connection.Close();
                return (data, headers);
            }
        }

        public static List<string[]> GetTableRows(string query, params string[] headers)
        {
            return GetTable(query, headers).data;
        }

        public static DataTable GetDataTable(string query, params string[] headers)
        {
            using (var dataTable = new DataTable())
            {
                foreach (var column in headers)
                    dataTable.Columns.Add(column);
                foreach (var row in GetTableRows(query, headers))
                    dataTable.Rows.Add(row);
                return dataTable;
            }
        }

        /// <summary>
        /// Old method that returns the view
        /// </summary>
        public static DataGridView GetDataGridView(string query, params string[] headers)
        {
            using (var dataGridView = new DataGridView())
            {
                for (var i = 0; i < headers.Length; i++)
                    dataGridView.Columns.Add(i.ToString(), headers[i]);
                foreach (var row in GetTableRows(query, headers))
                    dataGridView.Rows.Add(row);
                return dataGridView;
            }
        }
    }
}