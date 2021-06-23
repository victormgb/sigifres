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
    public partial class ADMINISTRAR_PROVEEDORES : Form
    {
        public ADMINISTRAR_PROVEEDORES()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MENU_ADMINISTRAR MENU_ADMINISTRAR = new MENU_ADMINISTRAR();
            MENU_ADMINISTRAR.Tag = this;
            MENU_ADMINISTRAR.Show(this);
            Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_proveedores", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@rif", txt_rif.Text);
                    cmd.Parameters.AddWithValue("@direccion", txt_direccion.Text);

                    cmd.Parameters.AddWithValue("@telefono", txt_telefono.Text);

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

                da = new SqlDataAdapter("mostrar_proveedores", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ADMINISTRAR_PROVEEDORES_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
        }

        private void datalistado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id_edit.Text = datalistado.SelectedCells[1].Value.ToString();
            txt_nombre_editar.Text = datalistado.SelectedCells[2].Value.ToString();
            txt_rif_editar.Text = datalistado.SelectedCells[3].Value.ToString();
            txt_direccion_editar.Text = datalistado.SelectedCells[4].Value.ToString();
            txt_telefono_editar.Text = datalistado.SelectedCells[5].Value.ToString();
            txt_estado_editar.Text = datalistado.SelectedCells[6].Value.ToString();
            panelEditar.Visible = true;
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_editar.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("editar_proveedor", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idProveedor", lbl_id_edit.Text);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre_editar.Text);
                    cmd.Parameters.AddWithValue("@rif", txt_rif_editar.Text);
                    cmd.Parameters.AddWithValue("@direccion", txt_direccion_editar.Text);

                    cmd.Parameters.AddWithValue("@telefono", txt_telefono_editar.Text);
                    int estado = 1;
                    if(txt_estado_editar.Text == "Activo")
                    {
                        estado = 1;
                    } else
                    {
                        estado = 0;
                    }

                    cmd.Parameters.AddWithValue("@estado", estado);

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = false;
        }
    }
}
