﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entity;

namespace DAL
{
    public class DetalleCotizacionRepository
    {
        private SqlConnection conexion;
        public DetalleCotizacionRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
        }
        public void Guardar(DetalleCotizacion detalleCotizacion)
        {
            using (SqlCommand sqlCommand = conexion.CreateCommand())
            {
                sqlCommand.CommandText = "insert into DetalleCotizacion(Cantidad,ValorTotal,CodFacturaCotizacion,CodProducto)" +
                    "values (@Cantidad,@ValorTotal,@CodFacturaCotizacion,@CodProducto))";
                sqlCommand.Parameters.AddWithValue("@Cantidad", detalleCotizacion.Cantidad);
                sqlCommand.Parameters.AddWithValue("@ValorTotal", detalleCotizacion.ValorTotal);
                sqlCommand.Parameters.AddWithValue("@CodFacturaCotizacion", detalleCotizacion.IdFactura );
                sqlCommand.Parameters.AddWithValue("@CodProducto", detalleCotizacion.CodProducto);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public DetalleCotizacion Mapear(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            DetalleCotizacion detalleCotizacion = new DetalleCotizacion();
            detalleCotizacion.CodigoDetalleFactura = (int)dataReader["CodDetalleCotizacion"];
            detalleCotizacion.Cantidad = (int)dataReader["Cantidad"];
            detalleCotizacion.ValorTotal = (decimal)dataReader["ValorTotal"];
            detalleCotizacion.IdFactura = (int)dataReader["CodFacturaCotizacion"];
            detalleCotizacion.IdProducto = (int)dataReader["CodProducto"];
            return detalleCotizacion;
        }

    }
}
