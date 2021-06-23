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
    public partial class GESTIONAR_COMPRA : Form
    {
        public GESTIONAR_COMPRA()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GESTIONAR_COMPRA_Load(object sender, EventArgs e)
        {
            mostrar();
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

                da = new SqlDataAdapter("mostrar_compras", con);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GESTIONAR_INVENTARIO GESTIONAR_INVENTARIO = new GESTIONAR_INVENTARIO();
            GESTIONAR_INVENTARIO.Tag = this;
            GESTIONAR_INVENTARIO.Show(this);
            Hide();
        }

        private void anadirCompra_Click(object sender, EventArgs e)
        {
            REGISTRAR_COMPRA REGISTRAR_COMPRA = new REGISTRAR_COMPRA();
            REGISTRAR_COMPRA.Tag = this;
            REGISTRAR_COMPRA.Show(this);
            Hide();
        }
    }
}
