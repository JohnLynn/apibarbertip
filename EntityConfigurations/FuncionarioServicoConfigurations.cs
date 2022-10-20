using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberTip.EntityConfigurations;
public class FuncionarioServicoConfigurations : IEntityTypeConfiguration<FuncionarioServico>
{
    public void Configure(EntityTypeBuilder<FuncionarioServico> builder)
    {
        builder.ToTable("FuncionarioServico");
        builder.HasKey(fs=>fs.Id); //PK

        //relacionamento
        builder.HasOne(fs=>fs.Funcionario) // (1,1)
               .WithMany(f=>f.FuncionarioServicos) // (0,n)
               .HasForeignKey(fs=>fs.IdFuncionario); //FK: funcionario
        
        //relacionamento
        builder.HasOne(fs=>fs.Servico) // (1,1)
               .WithMany(s=>s.FuncionarioServicos) // (0,n)
               .HasForeignKey(fs=>fs.IdServico); //FK: servico
    }
}