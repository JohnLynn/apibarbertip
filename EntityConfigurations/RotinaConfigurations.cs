using System.Diagnostics;
using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberTip.EntityConfigurations;

public class RotinaConfigurations : IEntityTypeConfiguration<Rotina>
{
    public void Configure(EntityTypeBuilder<Rotina> builder)
    {
        builder.ToTable("Rotinas");
        builder.HasKey(r=>r.Id); //PK

        builder.Property(r=>r.Dia) //atributo
               .IsRequired();
        builder.Property(r=>r.Hora) //atributo
               .IsRequired();
        
        //relacionamento
        builder.HasOne(r=>r.Funcionario) // (1,1)
               .WithOne(f=>f.Rotina) // (0,1)
               .HasForeignKey<Rotina>(r=>r.IdFuncionario);
    }
}