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
    public partial class REPORTE_GENERAL : Form
    {
        public REPORTE_GENERAL()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReporteVentas.ResumenVentas rpt = new ReporteVentas.ResumenVentas();
            rpt.table1.DataSource = null;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
    }
}
