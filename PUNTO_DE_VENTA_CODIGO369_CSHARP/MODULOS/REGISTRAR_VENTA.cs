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
    public partial class REGISTRAR_VENTA : Form
    {
        public REGISTRAR_VENTA()
        {
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() { return Text; }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GESTIONAR_VENTAS GESTIONAR_VENTAS = new GESTIONAR_VENTAS();
            GESTIONAR_VENTAS.Tag = this;
            GESTIONAR_VENTAS.Show(this);
            Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string producto_nombre = (combo_productos.SelectedItem as ComboboxItem).Text;
            string loteId = (combo_lotes.SelectedItem as ComboboxItem).Value;

            int rowId = dataVenta.Rows.Add();
            DataGridViewRow row = dataVenta.Rows[rowId];

            row.Cells[1].Value = producto_nombre;
            row.Cells[2].Value = loteId;
            row.Cells[3].Value = txt_cantidad.Value;
            row.Cells[4].Value = txt_unidad_producto.Text;
            row.Cells[5].Value = txt_precio_unit.Value;
            row.Cells[6].Value = txt_cantidad.Value * txt_precio_unit.Value;
            panelAnadirLista.Visible = false;

            calcular_total_venta();
            //vaciarPanelAnadir();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void REGISTRAR_VENTA_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void combo_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto_id = (combo_productos.SelectedItem as ComboboxItem).Value;

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
                    txt_unidad_producto.Text = oReader["unidad"].ToString();
                    txt_precio_unit.Text = oReader["precio_por_unidad"].ToString();

                    //para los lotes
                    obtenerLotesPorProducto(Int32.Parse(producto_id), oReader["unidad"].ToString());
                }

                con.Close();
            }
        }

        private void obtenerLotesPorProducto(int idProducto, string unidad)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("obtener_detallecompra_por_producto", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto", idProducto);
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {

                    System.Diagnostics.Debug.WriteLine(oReader["idDetalleCompra"].ToString());

                    ComboboxItem cbi = new ComboboxItem();
                    cbi.Text = "#" + oReader["idCompra"].ToString() + " - " + "Cantidad restante: " + oReader["cantidad"];
                    cbi.Value = oReader["idCompra"].ToString();
                    combo_lotes.Items.Add(cbi);
                }

                con.Close();
            }

            combo_lotes.Enabled = true;
        }

        private void anadirProductoButton_Click(object sender, EventArgs e)
        {
            panelAnadirLista.Visible = true;
        }

        private void botonRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (dataVenta.RowCount > 0)
            {
                registrarVenta();
            }
            else
            {
                MessageBox.Show("La lista de productos esta vacia. Por favor añada al menos 1 producto");
            }
        }

        private void registrarVenta()
        {
            // guaradar compra
            //guardarRegistroCompra();
            //// guardar cada una de la lista de compras
            //guardarDetalleCompra();
            //MessageBox.Show("Su compra se realizo correctamente");
            //GESTIONAR_COMPRA GESTIONAR_COMPRA = new GESTIONAR_COMPRA();
            //GESTIONAR_COMPRA.Tag = this;
            //GESTIONAR_COMPRA.Show(this);
            //Hide();
        }

        private void calcular_total_venta()
        {
            if (dataVenta.RowCount > 0)
            {
                Double total = 0;
                foreach (DataGridViewRow row in dataVenta.Rows)
                {
                    //System.Diagnostics.Debug.WriteLine(row.Cells[6].Value);

                    total = Convert.ToDouble(row.Cells[6].Value.ToString()) + total;

                }
                txt_total_venta.Text = Convert.ToString(total) + " $";
            }
            else
            {
                txt_total_venta.Text = "0 $";
            }
        }

        private void cerrarPanel_Click(object sender, EventArgs e)
        {
            panelAnadirLista.Visible = false;
        }
    }
}
