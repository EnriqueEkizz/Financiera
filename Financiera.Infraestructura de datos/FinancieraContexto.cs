using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Infraestructura_de_datos
{
    public class FinancieraContexto : DbContext
    {
        public FinancieraContexto() : base ("")
    {
            Database.SetInitializer<FinancieraContexto>(null);
        }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<CuentaCorriente> CuentasCorrientes { get; set; }
        #region Metodos
        protected override void onModelCreating(DbModelBuilder modelBuilder)
        {
            base.onModelCreating(ModelBuilder);
            base.Configuration.Add(new CuentaCorrienteMapeo());
            base.Configuration.Add(new ClienteMapeo());
        }
        #endregion
    }
}