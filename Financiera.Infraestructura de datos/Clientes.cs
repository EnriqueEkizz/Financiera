

public class ClienteMapeo : EntityTypeConfiguration<Cliente>
public ClienteMapeo()
toTable("Clientes","CC")
Haskey(k=>k.CodigoCliente);
Property(p =>p.CodigoCliente).HasColumnName("NUM_CLIENTE").IsRequired();
Property(p =>p.NombreCliente).HasColumnName("NOM_CLIENTE").IsRequired();
Property(p =>p.TipoCliente).HasColumnName("TIPO_CLIENTE").IsRequired();