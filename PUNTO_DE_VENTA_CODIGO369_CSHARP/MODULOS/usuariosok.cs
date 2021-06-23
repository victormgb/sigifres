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

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP
{
    public partial class usuariosok : Form
    {
        public usuariosok()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")

            {
                if (txtrol.Text != "")
                {

                    try
                    {


                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("insertar_usuario", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombres", txtnombre.Text);
                        cmd.Parameters.AddWithValue("@Login", txtlogin.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        cmd.Parameters.AddWithValue("@Correo", txtcorreo.Text);
                        cmd.Parameters.AddWithValue("@Rol", txtrol.Text);
                        cmd.Parameters.AddWithValue("@Estado", "ACTIVO");

                        cmd.ExecuteNonQuery();
                        con.Close();
                        //mostrar();
                        panel4.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else
                {
                    MessageBox.Show("Elija un Rol", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void usuariosok_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            //mostrar();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            txtnombre.Text = "";
            txtlogin.Text = "";
            txtPassword.Text = "";
            txtcorreo.Text = "";
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
        }
    }
}
