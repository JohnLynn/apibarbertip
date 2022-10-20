using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberTip.EntityConfigurations;
public class EnderecoConfigurations : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
       builder.ToTable("Enderecos");
       builder.HasKey(e=>e.Id); //PK

       builder.Property(e=>e.Logradouro) //atributo
              .IsRequired() //obrigatorio
              .HasMaxLength(80);
       builder.Property(e=>e.Numero) //atributo
              .IsRequired() //obrigatorio
              .HasMaxLength(11);
       builder.Property(e=>e.Bairro) //atributo
              .IsRequired() //obrigatorio
              .HasMaxLength(60);
       builder.Property(e=>e.Cidade) //atributo
              .IsRequired() //obrigatorio
              .HasMaxLength(60);
       builder.Property(e=>e.Cep) //atributo
              .IsRequired() //obrigatorio
              .HasMaxLength(8);

       //relacionamento
       builder.HasOne(e=>e.Funcionario) // (1,1)
              .WithMany(f=>f.Enderecos) // (1,n)
              .HasForeignKey(e=>e.IdFuncionario); //FK: funcionario
    }
}