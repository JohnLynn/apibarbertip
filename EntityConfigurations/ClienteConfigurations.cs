using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberTip.EntityConfigurations;
public class ClienteConfigurations : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(c=>c.Id); //PK
        builder.Property(c=>c.Nome)
               .IsRequired() //obrigatorio
               .HasMaxLength(60);
        builder.Property(c=>c.Telefone)
               .IsRequired() //obrigatorio
               .HasMaxLength(11);
        builder.Property(c=>c.Email)
               .IsRequired() //obrigatorio
               .HasMaxLength(60);
        builder.Property(c=>c.DataNascimento)
               .IsRequired(); //obrigatorio
    }
}