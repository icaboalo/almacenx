using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    class Usuario
    {
        public Int16 id { get; set; }

        public String login { get; set; }

        public String pwd { get; set; }

        public String nombre { get; set; }

        public Boolean activo { get; set; }

        public Boolean esAdmin { get; set; }

        public Boolean reportes { get; set; }

        public Usuario( Int16 i, String log, String pw, String nom, Boolean act, Boolean adm, Boolean rep)
        {
            id = i;
            login = log;
            pwd = pw;
            nombre = nom;
            activo = act;
            esAdmin = adm;
            reportes = rep;
        }
        public Usuario(Int16 i, String pw)
        {
            id = i;
            pwd = pw;
        }
        public void iniciar()
        {
            SqlConnection con;
            SqlDataReader dr;
            SqlCommand cmd;

            try
            {
                con = Conexion.addConnection();
                cmd = new SqlCommand(String.Format("select contra from usuarios where nombreUsuario= '{0}'", login), con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.GetString(0).Equals(pwd))
                    {
                        MessageBox.Show("¡Contraseña válida!");
                        AltaAlmacen w = new AltaAlmacen();
                        w.Show();
                    }
                    else
                        MessageBox.Show("¡Contraseña inválida!");
                }
                else
                {
                    MessageBox.Show("¡Usuario incorrecto! :(");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar --" + ex);
            }
        }
    }
}
