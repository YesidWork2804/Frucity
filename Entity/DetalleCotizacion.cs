﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class DetalleCotizacion : DetalleFactura
    {
        public DetalleCotizacion()
        {
        }


        public DetalleCotizacion(Producto producto, int cantidad) : base(producto, cantidad)
        {
            ObtenerDetalleFactura(producto, cantidad);
            CalcularValorTotal();
        }

        
        public override void CalcularValorTotal()
        {
            ValorTotal = CostoProducto * Cantidad;
        }
        public override string ToString()
        {
            return $"{IdProducto};{DescripcionProducto};" +
                $"{CategoriaProducto};{Presentacion};{Cantidad};{CostoProducto};{ValorTotal}";
        }
    }
}
