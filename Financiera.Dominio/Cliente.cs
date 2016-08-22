using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financiera.Dominio
{
    /// <summary>
    /// la la la la laSADASDF
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// andrea comento
        /// </summary>
        //lucero
        //que es esto 
        //lucero
        //al fin !!

        public int CodigoCliente{ get; set; }

        public string NombreCliente { get; set; }

        public byte TipoCliente { get; set; }

        public Cliente DarAlta(String as_nombre, byte aby_tipo)
        {
            return new Cliente()
            {
                NombreCliente = as_nombre,
                TipoCliente = aby_tipo,
            };
        }
        
        public void ModificarNombre(string as_nombre)
        {
            NombreCliente = as_nombre;
        }
    }
}