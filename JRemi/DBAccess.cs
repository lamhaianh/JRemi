using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
namespace JRemi
{
    class DBAccess
    {
        public static string stringConn = "Data Source=data.s3db";
        public static SQLiteConnection conn = null;
        private static void exit()
        {
            close();
            MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu");
            Application.Exit();
        }
        public static void open()
        {
            conn = new SQLiteConnection(stringConn);
            try
            {
                conn.Open();
            }
            catch
            {
                exit();
            }
           
        }

        public static void close()
        {
            conn.Close();
        }

        public static DataTable getDataTable(string sql)
        {
            DataTable dt = new DataTable();
            open();
            try
            {
                SQLiteCommand comd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = comd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                close();
                return dt;
            }
            catch
            {
                exit();
            }
            return null;
        }
        
        public static int executeNonQuery(string sql)
        {
            open();

            try
            {
                SQLiteCommand comd = new SQLiteCommand(sql, conn);
                int update = comd.ExecuteNonQuery();
                close();
                return update;
            }
            catch
            {
                exit();
            }
            return -1;
        }

        public static object executeScalar(string sql)
        {
            open();
            try
            {
                SQLiteCommand comd = new SQLiteCommand(sql, conn);
                object o = comd.ExecuteScalar();
                close();
                return o;
            }
            catch
            {
                exit();
            }
            return null;
        }
    }
}
