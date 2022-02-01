﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class FacturaCotizacion : Factura
    {
        public FacturaCotizacion()
        {
        }
        public FacturaCotizacion(decimal total,DateTime fecha, string nitProv)
        {
            Total = total;
            FechaExpedicion = fecha;
            NIT = nitProv;
        }
        public FacturaCotizacion(string nit)
        {
            NIT = nit;
        }
        public override void AgregarDetalle(Producto producto, int cantidad)
        {
            DetalleFactura detallefcturaCompra = new DetalleCotizacion(producto, cantidad);
            Detalles.Add(detallefcturaCompra);
        }

        public override List<DetalleFactura> ObtenerLista()
        {
            return Detalles;
        }
    }
}
