Financiera.Infraestructura_de_datos

   Public class FinancieraContexto : DbContext
{
    #region Constructor
    public FinacieraContexto() : base ("")
    {
        Database.SetInitializer<FiancieraContexto>(null);
    }
    #region Propiedades
    public DbSet<Clientes> Clientes { get; set; }

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