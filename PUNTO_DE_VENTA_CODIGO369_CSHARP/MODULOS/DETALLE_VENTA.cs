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
    public partial class DETALLE_VENTA : Form
    {

        private static int id_venta;

        public DETALLE_VENTA()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DETALLE_VENTA_Load(object sender, EventArgs e)
        {
            id_venta = MODELOS.Venta.id;
            idVenta.Text = id_venta.ToString();
            mostrar_detalle_venta();
            calcular_total();
        }

        private void mostrar_detalle_venta()
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
                    string sql = "mostrar_detalle_venta";
                    da.SelectCommand = new SqlCommand(sql, con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand.Parameters.AddWithValue("@idVenta", id_venta);
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
                Double total = 0;
                foreach (DataGridViewRow row in datalistado.Rows)
                {
                    //System.Diagnostics.Debug.WriteLine(row.Cells[6].Value);

                    total = Convert.ToDouble(row.Cells[5].Value.ToString()) + total;

                }
                txt_total_venta.Text = Convert.ToString(total) + " $";
            }
            else
            {
                txt_total_venta.Text = "0 $";
            }
        }
    }
}
