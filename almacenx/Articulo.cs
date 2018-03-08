using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace almacenx
{
    class Articulo
    {
        Int16 id, idEntrada, idArticulo;
        double cantidad, precioCompra;
        Articulo(Int16 id, Int16 idEntrada, Int16 idArticulo, double cantidad, double precioCompra)
        {
            this.id = id;
            this.idEntrada = idEntrada;
            this.idArticulo = idArticulo;
            this.cantidad = cantidad;
            this.precioCompra = precioCompra;
        }

        private int crearEntrada(String fechaRegistro, String fechaEntrada, String proveedor, Int16 folioFactura, String fechaFactura, Int16 usuario)
        {
            int res;
            SqlConnection con = Connection.addConnection();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO entrada VALUES ('{0}', '{1}', '{2}', {3}, '{4}', {5})", fechaRegistro, fechaEntrada, proveedor, folioFactura, fechaFactura, usuario), con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int agregarArticulo(String fechaRegistro, String fechaEntrada, String proveedor, Int16 folioFactura, String fechaFactura, Int16 usuario, Int16 idArticulo, double cantidad, double precioCompra)
        {
            if (crearEntrada(fechaRegistro, fechaEntrada, proveedor, folioFactura, fechaFactura, usuario) > 0)
            {
                int res = agregarArticulo(getEntrada(), idArticulo, cantidad, precioCompra);
                if (res > 0)
                {
                    MessageBox.Show("Entrada agregada");
                    return res;
                } else
                {
                    MessageBox.Show("Error al agregar la entrada");
                }
            } else
            {
                MessageBox.Show("Ocurrio un error al crear la entrada");
            }
            return -1;
        }

        private Int16 getEntrada()
        {
            SqlConnection con = Connection.addConnection();
            SqlCommand cmd = new SqlCommand("SELECT idEntrada from entrada order by idEntrada DESC limit 1;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Int16 res = reader.GetInt16(0);
            con.Close();
            return res;
        }

        private int agregarArticulo(Int16 idEntrada, Int16 idArticulo, double cantidad, double precioCompra)
        {
            int res;
            SqlConnection con = Connection.addConnection();
            SqlCommand cmd = new SqlCommand("", con);

            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

    }
}
