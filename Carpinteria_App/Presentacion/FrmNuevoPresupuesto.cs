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

namespace Carpinteria_App.Presentacion
{
    public partial class FrmNuevoPresupuesto : Form
    {
        Presupuesto presupuesto = null;

        public FrmNuevoPresupuesto()
        {
            InitializeComponent();
            presupuesto=new Presupuesto();
        }

        private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Today.ToShortDateString();
            TxtFecha.Enabled=false;

            TxtCliente.Text = "Consumidor Final";
            TxtDescuento.Text = "0";
            TxtCantidad.Text = "1";
            ProximoPresupuesto();
            cargarProductos();
        }

        private void cargarProductos()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Carpinteria_2023;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_PRODUCTOS";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            CboProducto.DataSource = tabla;
            CboProducto.ValueMember= tabla.Columns[0].ColumnName;
            CboProducto.DisplayMember = tabla.Columns[1].ColumnName;
             
        }

        private void ProximoPresupuesto()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Carpinteria_2023;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_ID";
            SqlParameter parametro= new SqlParameter();//Se pueden poner con parametros, y no ponerlo abajo("@Next",SqlDbType.Int )
            parametro.ParameterName= "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();

            LblPresupuesto.Text = LblPresupuesto.Text + " " + parametro.Value.ToString();
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
    }
}
