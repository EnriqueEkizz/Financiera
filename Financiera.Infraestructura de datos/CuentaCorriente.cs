

public class CuentaCorrienteMapeo : EntityTypeConfiguration<CuentaCorriente>

public CuentaCorrienteMapeo()
toTable("Clientes","CC")
Haskey(k =>k.NumeroCuenta);
Property(p =>p.NumeroCuenta).HasColumnName("NUM_CUENTA").IsRequired();
Property(p =>p.CodigoCuenta).HasColumnName("COD_CUENTA").IsRequired();
Property(p =>p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
Property(p =>p.FechaApertura).HasColumnName("FEC_APERTURA").IsRequired();
Property(p =>p.SaldoCuenta).HasColumnName("SAL_CUENTA").IsRequired();
Property(p =>p.EstadoCuenta).HasColumnName("IND_ESTADO").IsRequired();

HasRequired(M=>M.Propietario).WithMany().HasForeingKey(f.)