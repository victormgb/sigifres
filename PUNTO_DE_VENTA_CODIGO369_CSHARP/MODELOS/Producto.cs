using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.MODELOS
{
    class Producto
    {
        double stock;
        int id;

        public Producto()
        {
            this.id = 0;
            this.stock = 0;
        }
        public Producto(int id, double stock) {
            this.id = id;
            this.stock = stock;
        }   
        private static Producto obtenerProducto(int idProducto)
        {
            String stockProducto = "";
            Producto producto = new Producto();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("obtener_producto", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto", idProducto);
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    stockProducto = oReader["stock"].ToString();
                    producto.id = idProducto;
                    producto.stock = Convert.ToDouble(stockProducto);
                }

                con.Close();
            }

            return producto;


        }

        public static void aumentarStockProducto(int idProducto, double cantidad)
        {
            Producto producto = obtenerProducto(idProducto);
            producto.stock = producto.stock + cantidad;
            actualizarProducto(producto);
        }

        private static void actualizarProducto(Producto producto)
        {

        }
    }
}
