using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberTip.EntityConfigurations;
public class AgendamentoConfigurations : IEntityTypeConfiguration<Agendamento>
{
    public void Configure(EntityTypeBuilder<Agendamento> builder)
    {
       builder.ToTable("Agendamentos");

       builder.HasKey(a=>a.Id); //PK           
       builder.Property(a=>a.Data) //atributo
              .IsRequired(); //obrigatorio
       builder.Property(a=>a.Hora) //atributo
              .IsRequired(); //obrigatorio

       //relacionamento
       builder.HasOne(a=>a.Cliente) // (1,1)
              .WithMany(c=>c.Agendamentos) // (0,n)
              .HasForeignKey(a=>a.IdCliente); //FK: cliente        

       //relacionamento
       builder.HasOne(a=>a.FuncionarioServico) // (1,1)
              .WithMany(fs=>fs.Agendamentos) // (0,n)
              .HasForeignKey(a=>a.IdFuncionarioServico); //FK: funcionarioServico
    }
}