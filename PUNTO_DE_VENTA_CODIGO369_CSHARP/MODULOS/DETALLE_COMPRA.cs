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
    public partial class DETALLE_COMPRA : Form
    {
        public DETALLE_COMPRA()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DETALLE_COMPRA_Load(object sender, EventArgs e)
        {
            idCompra.Text = "5";
            mostrar_detalle_compra();
            calcular_total();
        }

        private void mostrar_detalle_compra()
        {
            try
            {
                DataTable dt = new DataTable();
                //SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                //da = new SqlDataAdapter("mostrar_detalle_venta", con);
                //da.SelectCommand.Parameters.AddWithValue("@idVenta", id_venta);
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    string sql = "mostrar_detalle_compra";
                    da.SelectCommand = new SqlCommand(sql, con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand.Parameters.AddWithValue("@idCompra", 5);
                    da.Fill(dt);
                    datalistado.DataSource = dt;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calcular_total()
        {
            if (datalistado.RowCount > 0)
            {
                double total = 0;
                foreach (DataGridViewRow row in datalistado.Rows)
                {
                    //System.Diagnostics.Debug.WriteLine(row.Cells[6].Value);

                    total = Convert.ToDouble(row.Cells[4].Value.ToString()) + total;

                }
                txt_total_compra.Text = Convert.ToString(total) + " $";
            }
            else
            {
                txt_total_compra.Text = "0 $";
            }
        }
    }
}
