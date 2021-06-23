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
    public partial class MENUPRINCIPAL : Form
    {
        public MENUPRINCIPAL()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            GESTIONAR_INVENTARIO GESTIONAR_INVENTARIO = new GESTIONAR_INVENTARIO();
            GESTIONAR_INVENTARIO.Tag = this;
            GESTIONAR_INVENTARIO.Show(this);
            Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MENUPRINCIPAL_Load(object sender, EventArgs e)
        {
            
        }
    }
}
