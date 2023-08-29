using Carpinteria_App.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria_App.Presentacion
{
    public partial class FrmConsultarPresupuesto : Form
    {
        
        public FrmConsultarPresupuesto()
        {
            InitializeComponent();
        }

        private void DgvPresupuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvPresupuesto.CurrentCell.ColumnIndex==4)
            {
                int nro = int.Parse(DgvPresupuesto.CurrentRow.Cells["ColNro"].Value.ToString());
                FrmDetallePresupuesto detalle=new FrmDetallePresupuesto(nro);
                detalle.ShowDialog();
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //validar campos de carga
           List<Parametros>lParametros= new List<Parametros>();
            lParametros.Add(new Parametros("@fecha_desde", DtpDesde.Value.ToString("yyyyMMdd")));
            lParametros.Add(new Parametros("@fecha_hasta", DtpHasta.Value.ToString("yyyyMMdd")));
            lParametros.Add(new Parametros("@cliente", TxtCliente.Text));

            DataTable tabla = new HelperDb().Consultar("SP_CONSULTAR_PRESUPUESTO", lParametros);
            DgvPresupuesto.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                DgvPresupuesto.Rows.Add(new object[] { fila["presupuesto_nro"].ToString(),
                                                       fila["fecha"].ToString(),
                                                       fila["cliente"].ToString(),
                                                       fila["total"].ToString()} );
            }
         
        }

        private void GrpFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void FrmConsultarPresupuesto_Load(object sender, EventArgs e)
        {
            DtpDesde.Value = DateTime.Now.AddDays(-7);
            DtpHasta.Value = DateTime.Now;
        }
    }
}
