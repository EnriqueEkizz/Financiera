using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financiera.Dominio
{
    public class CuentaCorriente
    {
        #region Propiedades
        public int NumeroCuenta
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string CodigoCuenta { get; set; }
        public int CodigoCliente { get; set; }
        public decimal SaldoCuenta { get; set; }
        public DateTime FechaApertura { get; set; }
        public byte EstadoCuenta { get; set; }
        public 
        public int Saldo
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int FechaApertura
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int EstadoCuenta
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Cliente Cliente
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Aperturar()
        {
            throw new System.NotImplementedException();
        }

        public void Cancelar()
        {
            throw new System.NotImplementedException();
        }

        public void Bloquear()
        {
            throw new System.NotImplementedException();
        }

        public void Desbloquear()
        {
            throw new System.NotImplementedException();
        }
    }
}