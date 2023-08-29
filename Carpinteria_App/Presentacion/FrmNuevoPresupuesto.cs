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
using Carpinteria_App.Entidades;
using Carpinteria_App.Datos;

namespace Carpinteria_App.Presentacion
{
    public partial class FrmNuevoPresupuesto : Form
    {
        Presupuesto presupuesto = null;
        HelperDb gestor= null;

        public FrmNuevoPresupuesto()
        {
            InitializeComponent();
            presupuesto=new Presupuesto();
            gestor=new HelperDb();
        }

        private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Today.ToShortDateString();
            TxtFecha.Enabled=false;

            TxtCliente.Text = "Consumidor Final";
            TxtDescuento.Text = "0";
            TxtCantidad.Text = "1";
            LblPresupuesto.Text = LblPresupuesto.Text + " " + gestor.ProximoPresupuesto().ToString();
            cargarProductos();
          
        }

        private void cargarProductos()
        {
            DataTable tabla = 
            gestor.Consultar("SP_CONSULTAR_PRODUCTOS");
            CboProducto.DataSource = tabla;
            CboProducto.ValueMember= tabla.Columns[0].ColumnName;
            CboProducto.DisplayMember = tabla.Columns[1].ColumnName;
             
        }

       

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (CboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto..","Control",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                CboProducto.Focus();
                return;
            }
            if(string.IsNullOrEmpty(TxtCantidad.Text) || !int.TryParse(TxtCantidad.Text,out _))
            { 
                MessageBox.Show("Debe ingresar una cantidad valida..","Agregar",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                TxtCantidad.Focus();
                return;
            }
            foreach (DataGridViewRow row in DgbDetalle.Rows)
            {
                if (row.Cells["ColProducto"].Value.ToString().Equals(CboProducto.Text))
                {
                    MessageBox.Show("Este producto ya esta presupuestado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CboProducto.Focus();
                    return;
                }
            }

            DataRowView item = (DataRowView)CboProducto.SelectedItem;

            int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            double pre= Convert.ToDouble(item.Row.ItemArray[2].ToString());
            
            Producto p = new Producto(nro,nom,pre);

            int cant = Convert.ToInt32(TxtCantidad.Text);

            DetallePresupuesto detalle = new DetallePresupuesto(p,cant);
           
            presupuesto.AgregarDetalle(detalle);
            //DgbDetalle.Rows.Add(new object[] {detalle.Producto.ProductoNro,
            //                                   detalle.Producto.Nombre,
            //                                     detalle.Producto.Precio,
            //                                       detalle.Cantidad,
            //                                        "Quitar" });
            DgbDetalle.Rows.Add(new object[] { nro, nom, pre, cant, "Quitar" });

            CalcularTotales(); 
        }

        private void CalcularTotales()
        {
            TxtSubtotal.Text=presupuesto.CalcularTotal().ToString();
            if (!string.IsNullOrEmpty(TxtDescuento.Text) && int.TryParse(TxtDescuento.Text, out _))
            {
                double desc = presupuesto.CalcularTotal() * Convert.ToDouble(TxtDescuento.Text) / 100;
                TxtTotal.Text = (presupuesto.CalcularTotal() - desc).ToString();
            }
        }

        private void DgbDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgbDetalle.CurrentCell.ColumnIndex == (DgbDetalle.ColumnCount - 1))
            {
                presupuesto.QuitarDetalle(DgbDetalle.CurrentRow.Index);
                DgbDetalle.Rows.RemoveAt(DgbDetalle.CurrentRow.Index);
                CalcularTotales();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //VALIDAR

            if (string.IsNullOrEmpty(TxtCliente.Text))
            {
                MessageBox.Show("Debe ingresar un cliente..","Control",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;            
            }
            if (DgbDetalle.Rows.Count==0)
            {
                MessageBox.Show("Debe ingresar al menos un detalle ..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //CONFIRMAR O GRABAR
            GrabarPresupuesto();
        }

        private void GrabarPresupuesto()
        {
            presupuesto.Fecha=Convert.ToDateTime(TxtFecha.Text);
            presupuesto.Cliente=TxtCliente.Text;
            presupuesto.Descuento=Convert.ToDouble(TxtDescuento.Text);
            if (gestor.ConfirmarPresupuesto(presupuesto))
            {
                MessageBox.Show("Se registro con exito!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el presupuesto!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
