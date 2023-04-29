using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gw2r_HMS
{
    internal class crud
    {
        static SqlConnection conn;
        public static void createCon()
        {
            string constring = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            conn = new SqlConnection(constring);
            conn.Open();
        }

        public static void insertData(string query)
        {
            //create patient records
            SqlCommand cmd = new SqlCommand (query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Patient Record Added Successfully");
            }
        }
        public static DataTable readData (string query)
        {
            //display all patient records
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();
            dt.Load(r);
            return dt;
        }

        public static void updateData(string query)
        {
            //Update patient record
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Patient Record Updated Successfully");
            }
        }
        public static void deleteData(string query)
        {
            //delete patient record
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Patient Record Deleted Successfully");
            }
        }
        public static void updateCon() 
        {
            conn.Close();
        }
    }
}
