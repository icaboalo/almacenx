using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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

        public static void fillArticles(ComboBox comboBox)
        {
            SqlConnection con = addConnection();
            SqlCommand command = new SqlCommand("SELECT idArticulo FROM entArticulo;", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader["idArticulo"].ToString());
            }
            comboBox.SelectedIndex = 0;
            con.Close();
        }

        public static void fillUsers(ComboBox comboBox)
        {
            SqlConnection con = addConnection();
            SqlCommand command = new SqlCommand("SELECT idUser FROM usuario;", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader["idUser"].ToString());
            }
            comboBox.SelectedIndex = 0;
            con.Close();
        }
    }
}
