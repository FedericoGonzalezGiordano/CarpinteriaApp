﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria_App.Entidades
{
    public class DetallePresupuesto
    {
        private Producto p;
        private int cant;

        public DetallePresupuesto(Producto p, int cant)
        {
            this.p = p;
            this.cant = cant;
        }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }


        public double CalcularSubtotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}
