using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.MODULOS
{
    public partial class MENU_ADMINISTRAR : Form
    {
        public MENU_ADMINISTRAR()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            ADMINISTRAR_USUARIOS ADMINISTRAR_USUARIOS = new ADMINISTRAR_USUARIOS();
            ADMINISTRAR_USUARIOS.Tag = this;
            ADMINISTRAR_USUARIOS.Show(this);
            Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            ADMINISTRAR_PROVEEDORES ADMINISTRAR_PROVEEDORES = new ADMINISTRAR_PROVEEDORES();
            ADMINISTRAR_PROVEEDORES.Tag = this;
            ADMINISTRAR_PROVEEDORES.Show(this);
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MENUPRINCIPAL MENUPRINCIPAL = new MENUPRINCIPAL();
            MENUPRINCIPAL.Tag = this;
            MENUPRINCIPAL.Show(this);
            Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
