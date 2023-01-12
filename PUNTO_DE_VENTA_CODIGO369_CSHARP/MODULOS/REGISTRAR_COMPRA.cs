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

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.MODULOS
{
    public partial class REGISTRAR_COMPRA : Form
    {

        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() { return Text; }
        }

        //private List<ComboboxItem> comboListProduct = new List<ComboboxItem>();
        public REGISTRAR_COMPRA()
        {
            InitializeComponent();
        }

        private void REGISTRAR_COMPRA_Load(object sender, EventArgs e)
        {
            mostrarProductos();
            mostrarProveedores();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if(combo_productos.Text != "")
            {
                string producto_id = (combo_productos.SelectedItem as ComboboxItem).Value;
                string producto_nombre = (combo_productos.SelectedItem as ComboboxItem).Text;

                //Double cantidad = Convert.ToDouble(txt_cantidad.Value);
                //Double precio_kilo = Convert.ToDouble(txt_precio_kilo.Value);

                int rowId = dataCompra.Rows.Add();
                DataGridViewRow row = dataCompra.Rows[rowId];

                row.Cells[1].Value = producto_id;
                row.Cells[2].Value = producto_nombre;
                row.Cells[3].Value = txt_peso.Value;
                row.Cells[4].Value = txt_unidad_producto.Text;
                row.Cells[5].Value = txt_precio_kilo.Value;
                row.Cells[6].Value = txt_peso.Value * txt_precio_kilo.Value;
                panelAnadirProducto.Visible = false;

                calcular_total_compra();
                vaciarPanelAnadir();
            }
        }

        private void anadirProducto_Click(object sender, EventArgs e)
        {
            panelAnadirProducto.Visible = true;
        }

        private void mostrarProductos()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            con.Open();

            da = new SqlDataAdapter("mostrar_productos", con);
            da.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                //combo_productos.Items.Add(new { Text = dr["descripcion"].ToString(), Value = dr["idProducto"].ToString() });
                ComboboxItem cbi = new ComboboxItem();
                cbi.Text = dr["descripcion"].ToString();
                cbi.Value = dr["idProducto"].ToString();
                combo_productos.Items.Add(cbi);
            }

        }

        private void mostrarProveedores()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            con.Open();

            da = new SqlDataAdapter("mostrar_proveedores", con);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ComboboxItem cbi = new ComboboxItem();
                cbi.Text = dr["nombre"].ToString();
                cbi.Value = dr["idProveedor"].ToString();
                combo_proveedores.Items.Add(cbi);
            }
        }

        private void combo_productos_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void combo_productos_SelectedIndexChanged(object sender, EventArgs e)
        {


            string producto_id = (combo_productos.SelectedItem as ComboboxItem).Value;

            // Obtener unidad del producto
            //DataTable dt = new DataTable();
            //SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("obtener_producto", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto", producto_id);
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    txt_unidad_producto.Text= oReader["unidad"].ToString();
                    txt_precio_kilo.Text = oReader["precio_por_unidad"].ToString();
                }

                con.Close();
            }

        }

        private void cerrarPanel_Click(object sender, EventArgs e)
        {
            panelAnadirProducto.Visible = false;
        }

        private void dataCompra_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == this.dataCompra.Columns["eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente desea eliminar este Producto de la lista?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    dataCompra.Rows.RemoveAt(e.RowIndex);
                    calcular_total_compra();
                }
            }
        }

        private void calcular_total_compra()
        {
            if(dataCompra.RowCount > 0)
            {
                Double total = 0;
                foreach (DataGridViewRow row in dataCompra.Rows)
                {
                    //System.Diagnostics.Debug.WriteLine(row.Cells[6].Value);

                    total = Convert.ToDouble(row.Cells[6].Value.ToString()) + total;
                    
                }
                txt_total_compra.Text = Convert.ToString(total) + " $";
            } else
            {
                txt_total_compra.Text = "0.00 $";
            }
        }

        private void vaciarPanelAnadir()
        {
            combo_productos.Text = "";
            txt_peso.Value = 0;
            txt_precio_kilo.Value = 0;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if(combo_proveedores.Text != "")
            {
                if (dataCompra.RowCount > 0)
                {
                    registrarCompra();
                } else
                {
                    MessageBox.Show("La lista de productos esta vacia. Por favor añada al menos 1 producto");
                }
            } else
            {
                MessageBox.Show("No se ha seleccionado Proveedor");
            }
        }

        private void registrarCompra()
        {
            // guaradar compra
            guardarRegistroCompra();
            // guardar cada una de la lista de compras
            guardarDetalleCompra();
            MessageBox.Show("Su compra se realizo correctamente");
            GESTIONAR_COMPRA GESTIONAR_COMPRA = new GESTIONAR_COMPRA();
            GESTIONAR_COMPRA.Tag = this;
            GESTIONAR_COMPRA.Show(this);
            Hide();
        }

        private void guardarRegistroCompra()
        {

            int idProveedor = Int32.Parse((combo_proveedores.SelectedItem as ComboboxItem).Value);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insertar_compra", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idUsuario", MODELOS.Usuario.id);
            cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
            cmd.Parameters.AddWithValue("@fechaCompra", DateTime.Now);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void guardarDetalleCompra()
        {
            int idCompra = obtenerUltimaCompra();
            foreach (DataGridViewRow row in dataCompra.Rows)
            {

                double cantidad = Convert.ToDouble(row.Cells[3].Value.ToString());
                double precio_unit = Convert.ToDouble(row.Cells[5].Value.ToString());


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_detalle_compra", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCompra", idCompra);
                cmd.Parameters.AddWithValue("@idProducto", Int32.Parse(row.Cells[1].Value.ToString()));
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precioUnitario", precio_unit);

                cmd.ExecuteNonQuery();
                con.Close();                

            }
        }

        private void actualizarStockProducto()
        {

        }

        public int obtenerUltimaCompra()
        {
            String idCompra = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("obtener_ultima_compra", con);
            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    idCompra = oReader["idCompra"].ToString();
                }
                con.Close();
                
            }
            return Int32.Parse(idCompra);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_peso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_unidad_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_precio_kilo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
