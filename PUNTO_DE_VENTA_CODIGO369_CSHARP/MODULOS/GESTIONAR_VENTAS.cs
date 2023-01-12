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
    public partial class GESTIONAR_VENTAS : Form
    {
        public GESTIONAR_VENTAS()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_ventas", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                //datalistado.Columns[1].Visible = false; id
                //datalistado.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GESTIONAR_VENTAS_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GESTIONAR_INVENTARIO GESTIONAR_INVENTARIO = new GESTIONAR_INVENTARIO();
            GESTIONAR_INVENTARIO.Tag = this;
            GESTIONAR_INVENTARIO.Show(this);
            Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            REGISTRAR_VENTA REGISTRAR_VENTA = new REGISTRAR_VENTA();
            REGISTRAR_VENTA.Tag = this;
            REGISTRAR_VENTA.Show(this);
            Hide();
        }

        private void datalistado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                string idVenta = this.datalistado.Rows[e.RowIndex].Cells[1].Value.ToString();
                int id = Int32.Parse(idVenta);
                MODELOS.Venta.id = id;

                DETALLE_VENTA DETALLE_VENTA = new DETALLE_VENTA();
                DETALLE_VENTA.Tag = this;
                DETALLE_VENTA.Show(this);
                Hide();
            }
        }
    }
}
