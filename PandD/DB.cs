using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PandD
{
    public class AnExep : System.Exception
    {
        public const string rongDataMessage = "Error: There is Empty Value!";

        public AnExep ()
        {
        }
        public void get_msg()
        {
            MessageBox.Show(rongDataMessage);
        }
    };
    
    public class DB
    {
        /// The private singleton instance of the database.
        static DB _instance;
        public SqlConnection con;
        private static readonly object syncLock = new object();
        public int condation; 
        private DB(string s)
        {
            con = new SqlConnection(s);
        }
        public static DB GetInstance()
        {
            lock (syncLock)
            {
                if (_instance == null)
                {
                    return _instance = new DB("Data Source=ERAKY\\SQLEXPRESS;Initial Catalog=P&D;Integrated Security=True");
                }
            }
            return _instance;
        }

        public void cancelconnection()
        {
            con.Close();
        }

        public DataTable display(string quere, string[] s)
        {
            DataTable p = new DataTable();
            try
            {
                DB.GetInstance().con.Open();
                SqlCommand cmd = new SqlCommand(quere, con);
                SqlDataReader reader = cmd.ExecuteReader();

                for (int i = 0; i < s.Count(); ++i)
                {

                    p.Columns.Add(s[i]);
                }

                

                DataRow row;
                while (reader.Read())
                {
                    row = p.NewRow();
                    for (int i = 0; i < s.Count(); ++i)
                    {
                        row[s[i]] = reader[s[i]];
                    }
                    p.Rows.Add(row);
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: you must fill data correctly!");
            }
                con.Close();
                return p;
            

        }

        public void proc(string pro, string[] s, string[] d)
        {
            try
            {

                DB.GetInstance().con.Open();
                SqlCommand cmd = new SqlCommand(pro, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < s.Count(); i++)
                {
                    cmd.Parameters.Add(new SqlParameter(s[i], d[i]));
                     
                }
                cmd.ExecuteNonQuery();
            }
            
            catch (Exception)
            {
                MessageBox.Show("Error: you must fill data correctly!");

            }


            con.Close();
        }

    }
}
