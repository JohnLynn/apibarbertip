using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberTip.EntityConfigurations;
public class AtividadeConfigurations : IEntityTypeConfiguration<Atividade>
{
    public void Configure(EntityTypeBuilder<Atividade> builder)
    {
        builder.ToTable("Atividades");

        builder.HasKey(at=>at.Id); //PK

        builder.Property(at=>at.Status)//atributo
               .IsRequired(); //obrigatorio     
        
        //relacionamento
        builder.HasOne(at=>at.Agendamento) // (1,1)
               .WithOne(a=>a.Atividade) // (1,1)
               .HasForeignKey<Atividade>(at=>at.IdAgendamento); //FK: agendamento         
    }
}