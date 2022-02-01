﻿using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public  class DetalleCotizacionService
    {
        private ConnectionManager connection;
        private DetalleCotizacionRepository repository;

        public DetalleCotizacionService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new DetalleCotizacionRepository(connection);
        }

        public string GuardarDetalle(DetalleCotizacion detalle)
        {
            try
            {
                //int productoString = detalle.NumeroFactura;
                connection.Open();
                repository.Guardar(detalle);
                connection.Close();
                return $"OK";
            }
            catch (Exception e)
            {
                return $"Error de la aplicacion"+e.Message;
            }
            finally { connection.Close(); }
        }
    }
}
