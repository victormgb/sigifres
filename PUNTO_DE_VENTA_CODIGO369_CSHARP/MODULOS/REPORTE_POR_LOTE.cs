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
    public partial class REPORTE_POR_LOTE : Form
    {
        public REPORTE_POR_LOTE()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReporteVentas.ReporteVentasLote rpt = new ReporteVentas.ReporteVentasLote();
            rpt.table1.DataSource = null;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
    }
}
