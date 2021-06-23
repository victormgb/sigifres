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
    public partial class GESTIONAR_INVENTARIO : Form
    {
        public GESTIONAR_INVENTARIO()
        {
            InitializeComponent();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            GESTIONAR_PRODUCTOS GESTIONAR_PRODUCTOS = new GESTIONAR_PRODUCTOS();
            GESTIONAR_PRODUCTOS.Tag = this;
            GESTIONAR_PRODUCTOS.Show(this);
            Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        { 

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MENUPRINCIPAL MENUPRINCIPAL = new MENUPRINCIPAL();
            MENUPRINCIPAL.Tag = this;
            MENUPRINCIPAL.Show(this);
            Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            GESTIONAR_VENTAS GESTIONAR_VENTAS = new GESTIONAR_VENTAS();
            GESTIONAR_VENTAS.Tag = this;
            GESTIONAR_VENTAS.Show(this);
            Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            GESTIONAR_COMPRA GESTIONAR_COMPRA = new GESTIONAR_COMPRA();
            GESTIONAR_COMPRA.Tag = this;
            GESTIONAR_COMPRA.Show(this);
            Hide();
        }
    }
}
