﻿using System;

namespace Entity
{
    public abstract class Persona
    {
        public string NIT { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Persona()
        {

        }
        public Persona(string nit, string nombre, string direccion,
            string telefono)
        {
            NIT = nit;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;

        }
        public abstract override string ToString();
    }
}
