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
    public partial class GESTIONAR_PRODUCTOS : Form
    {
        public GESTIONAR_PRODUCTOS()
        {
            InitializeComponent();
        }

        private void botonAnadir_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text != "" && txt_nombre.Text != "" )
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_producto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@codigo", txt_codigo.Text);
                    cmd.Parameters.AddWithValue("@precio_unidad", txt_precio_unidad.Text);
                    cmd.Parameters.AddWithValue("@estado", txt_estado.Text);
                    cmd.Parameters.AddWithValue("@unidad", txt_unidad.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrar();
                    panelRegistro.Visible = false;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("error");
                    MessageBox.Show(ex.Message);

                }
            }
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

                da = new SqlDataAdapter("mostrar_productos", con);
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

        private void GESTIONAR_PRODUCTOS_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_editar.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("editar_producto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", lbl_id_producto.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txt_nombre_editar.Text);
                    cmd.Parameters.AddWithValue("@codigo", txt_codigo_editar.Text);
                    cmd.Parameters.AddWithValue("@stock", txt_stock_editar.Text);

                    //int estado = 1;
                    //if (txt_estado_edit.Text == "Activo")
                    //{
                    //    estado = 1;
                    //}
                    //else
                    //{
                    //    estado = 0;
                    //}
                    //cmd.Parameters.AddWithValue("@estado", estado);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrar();
                    panelEditar.Visible = false;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("error");
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void datalistado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id_producto.Text = datalistado.SelectedCells[1].Value.ToString();
            txt_nombre_editar.Text = datalistado.SelectedCells[2].Value.ToString();
            txt_codigo_editar.Text = datalistado.SelectedCells[2].Value.ToString();
            txt_stock_editar.Text = datalistado.SelectedCells[3].Value.ToString();
            panelEditar.Visible = true;
        }

        private void buscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_producto", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@busqueda", txt_buscar.Text);
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

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_producto", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@busqueda", txt_buscar.Text);
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

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_precio_unidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cerrarPanelAnadir_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
        }

        private void cerrarPanelEditar_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = false;
        }
    }
}
