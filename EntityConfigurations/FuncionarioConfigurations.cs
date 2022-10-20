using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberTip.EntityConfigurations;
public class FuncionarioConfigurations : IEntityTypeConfiguration<Funcionario>
{
    public void Configure(EntityTypeBuilder<Funcionario> builder)
    {
        builder.ToTable("Funcionarios");
        builder.HasKey(f=>f.Id); //PK
        builder.Property(f=>f.Nome) //atributo
               .IsRequired()
               .HasMaxLength(60);
        builder.Property(f=>f.Cpf) //atributo
               .IsRequired()
               .HasMaxLength(11);
        builder.Property(f=>f.Telefone) //atributo
               .IsRequired()
               .HasMaxLength(11);
        builder.Property(f=>f.Email) //atributo
               .IsRequired()
               .HasMaxLength(60);
        builder.Property(f=>f.DataNascimento) //atributo
               .IsRequired();
        builder.Property(f=>f.Funcao) //atributo
               .IsRequired()
               .HasMaxLength(60);
    }
}