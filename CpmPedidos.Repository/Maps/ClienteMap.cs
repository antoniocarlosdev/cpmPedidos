using CpmPedidosDomain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repository
{
    public class ClienteMap : BaseDomainMap<Cliente>
    {
        public ClienteMap() : base("tb_cliente") { }

        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);
            builder.HasKey(p => p.Id);
            builder.HasKey(p => p.IdEndereco);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Cpf).HasColumnName("cpf").HasMaxLength(11).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();

            builder.Property(x => x.IdEndereco).HasColumnName("id_endereco").IsRequired();

            builder.HasOne(x => x.Endereco).WithOne(x => x.Cliente).HasForeignKey<Cliente>(x => x.IdEndereco).HasConstraintName("FK_cliente_endereco");
        }
    }
}
