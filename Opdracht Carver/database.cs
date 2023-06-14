using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Carver
{
    public class Database
    {
        string cn = @"Data Source=LAPTOP-H994TPDO\SQLEXPRESS;Initial Catalog=Carver;Trusted_Connection=Yes;TrustServerCertificate=True";
        SqlConnection con;

        public void OpenConnection()
        {
            con = new SqlConnection(cn);
            con.Open();
        }

        public string ExecuteQueries(string sql)
        {
            string errorStr = "";
            OpenConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                errorStr = "De opdracht is verwerkt.";
            }
            catch (Exception e)
            {
                errorStr = e.ToString();
            }
            CloseConnection();
            return errorStr;
        }

        public SqlDataReader DataReader(string sql)
        {
            //Deze method geeft de return waarde van 1 datarij
            //Gebruik dit bijvoorbeeld voor een textbox of label

            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridView(string sql)
        {
            SqlDataAdapter dr = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public void CloseConnection()
        {
            con.Close();
        }
    }
}
