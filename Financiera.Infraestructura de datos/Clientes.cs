using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Infraestructura_de_datos
{

    public class ClienteMapeo : EntityTypeConfiguration<Cliente>
    {

        public class ClienteMapeo()

        toTable("Clientes", "CC");
        Haskey(k => k.CodigoCliente);
        Property(p => p.CodigoCliente).HasColumnName("NUM_CLIENTE").IsRequired();
        Property(p => p.NombreCliente).HasColumnName("NOM_CLIENTE").IsRequired();
        Property(p => p.TipoCliente).HasColumnName("TIPO_CLIENTE").IsRequired();
    
    }
}