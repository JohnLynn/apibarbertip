using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BarberTip.Entities;

namespace BarberTip.EntityConfigurations;

public class ServicoConfigurations : IEntityTypeConfiguration<Servico>
{
    public void Configure(EntityTypeBuilder<Servico> builder)
    {
        builder.ToTable("Servicos");
        builder.HasKey(s=>s.Id); //PK
        
        builder.Property(s=>s.Nome)
            .IsRequired() //obrigatorio
            .HasMaxLength(60);

        builder.Property(s=>s.Valor)
            .IsRequired(); //obrigatorio
        
        builder.Property(s=>s.Tempo)
            .IsRequired(); //obrigatorio
    }
}