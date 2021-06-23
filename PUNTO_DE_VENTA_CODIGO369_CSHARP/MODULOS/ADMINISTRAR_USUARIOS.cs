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
    public partial class ADMINISTRAR_USUARIOS : Form
    {
        public ADMINISTRAR_USUARIOS()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if(txt_nombre_apellido.Text != "")
            {
                try
                {
                    string contra_encriptada = UTILIDADES.Encrypt.GetSHA256(txt_contrasena.Text);

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_usuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre_apellido", txt_nombre_apellido.Text);
                    cmd.Parameters.AddWithValue("@login", txt_usuario.Text);
                    

                    cmd.Parameters.AddWithValue("@password", contra_encriptada);

                    cmd.Parameters.AddWithValue("@correo", txt_correo.Text);
                    cmd.Parameters.AddWithValue("@rol", txt_rol.Text);
                    cmd.Parameters.AddWithValue("@estado", 1);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrar();
                    panelRegistros.Visible = false;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("error");
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonAnadir_Click(object sender, EventArgs e)
        {
            panelRegistros.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelRegistros.Visible = false;
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

                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                //datalistado.Columns[1].Visible = false; id
                datalistado.Columns[3].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ADMINISTRAR_USUARIOS_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void datalistado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id_edit.Text = datalistado.SelectedCells[1].Value.ToString();
            txt_nombre_edit.Text = datalistado.SelectedCells[2].Value.ToString();
            txt_usuario_edit.Text = datalistado.SelectedCells[2].Value.ToString();
            txt_contra_edit.Text = datalistado.SelectedCells[3].Value.ToString();
            txt_correo_edit.Text = datalistado.SelectedCells[4].Value.ToString();
            txt_rol_edit.Text = datalistado.SelectedCells[5].Value.ToString();
            txt_estado_edit.Text = datalistado.SelectedCells[6].Value.ToString();
            panelEditar.Visible = true;
           

            // se copian los demas
            // mostrar el panel de edicion
            //programar el anterior boton para edicion
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txt_nombre_edit.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("editar_usuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", lbl_id_edit.Text);
                    cmd.Parameters.AddWithValue("@nombre_apellido", txt_nombre_edit.Text);
                    cmd.Parameters.AddWithValue("@login", txt_usuario_edit.Text);
                    cmd.Parameters.AddWithValue("@password", txt_contra_edit.Text);

                    cmd.Parameters.AddWithValue("@correo", txt_correo_edit.Text);
                    cmd.Parameters.AddWithValue("@rol", txt_rol_edit.Text);
                    int estado = 1;
                    if (txt_estado_edit.Text == "Activo")
                    {
                        estado = 1;
                    }
                    else
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

        private void panelEditar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MENU_ADMINISTRAR MENU_ADMINISTRAR = new MENU_ADMINISTRAR();
            MENU_ADMINISTRAR.Tag = this;
            MENU_ADMINISTRAR.Show(this);
            Hide();
        }
    }
}
