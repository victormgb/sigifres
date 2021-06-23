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
using System.Text.RegularExpressions;

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.MODULOS
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            validar_login();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void validar_login()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("validar_usuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@login", txt_usario.Text);

            string contra_encriptada = UTILIDADES.Encrypt.GetSHA256(txt_contra.Text);

            cmd.Parameters.AddWithValue("@password", contra_encriptada);

            SqlDataAdapter daParentLogin = new SqlDataAdapter(cmd);
            DataSet result = new DataSet();

            daParentLogin.Fill(result, "login");
            con.Close();
            if (result.Tables["login"].Rows.Count > 0)
            {
                string idUsuario = result.Tables["login"].Rows[0]["id"].ToString();
                guardarIdUsuario(idUsuario);
                ingresar();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void ingresar()
        {
            MENUPRINCIPAL MENUPRINCIPAL = new MENUPRINCIPAL();
            MENUPRINCIPAL.Tag = this;
            MENUPRINCIPAL.Show(this);
            Hide();
        }

        private void LOGIN_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_usario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                validar_login();
            }
        }

        private void txt_contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                validar_login();
            }
        }

        private void guardarIdUsuario(string idUsuario)
        {
            int id = Int32.Parse(idUsuario);
            MODELOS.Usuario.id = id;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string correo = txt_correo_recuperar.Text;
            correo = Regex.Replace(correo, @"\s+", "");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("verificar_correo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            System.Diagnostics.Debug.WriteLine(correo);
            cmd.Parameters.AddWithValue("@correo", correo);

            SqlDataAdapter daParentLogin = new SqlDataAdapter(cmd);
            DataSet result = new DataSet();

            daParentLogin.Fill(result, "correo");
            
            con.Close();
            System.Diagnostics.Debug.WriteLine(result.Tables["correo"]);
            if (result.Tables["correo"].Rows.Count > 0)
            {
                procesarCorreo(correo);
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void procesarCorreo(string correo)
        {
            string contrasena = generadorDeContrasena();
            string mensaje = "Su nuevo password para acceder al sistema es: <strong>" + contrasena + "</strong>";
            string asunto = "Recuperacion de contraseña en el sistema SIGIFRES";

            //Se envia la contrseña
            UTILIDADES.EnviarCorreo.recuperarContrasena(mensaje, asunto, correo);
        }

        private string generadorDeContrasena()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 10;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
            return contraseniaAleatoria;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRecuperarContra.Visible = true;
        }

        private void cerrarPanel_Click(object sender, EventArgs e)
        {
            panelRecuperarContra.Visible = false;
        }
    }
}
