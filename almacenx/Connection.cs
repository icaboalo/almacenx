using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace almacenx
{
    class Connection
    {

        public static SqlConnection addConnection()
        {
            SqlConnection con;
            try
            {
                con = new SqlConnection("");
                con.Open();
            } catch (Exception e)
            {
                con = null;
                MessageBox.Show("No se pudo contectar " + e.Message);
            }
            return con;
        }


    }
}
