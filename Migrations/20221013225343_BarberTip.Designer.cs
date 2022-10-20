﻿// <auto-generated />
using System;
using BarberTip.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiBarberTip.Migrations
{
    [DbContext(typeof(BarberTipContext))]
    [Migration("20221013225343_BarberTip")]
    partial class BarberTip
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BarberTip.Entities.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncionarioServico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdFuncionarioServico");

                    b.ToTable("Agendamentos", (string)null);
                });

            modelBuilder.Entity("BarberTip.Entities.Atividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdAgendamento")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAgendamento")
                        .IsUnique();

                    b.ToTable("Atividades", (string)null);
                });

            modelBuilder.Entity("BarberTip.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("BarberTip.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Cep")
                        .HasMaxLength(8)
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("Numero")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Enderecos", (string)null);
                });

            modelBuilder.Entity("BarberTip.Entities.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Telefone")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios", (string)null);
                });

            modelBuilder.Entity("BarberTip.Entities.FuncionarioServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("IdServico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdFuncionario");

                    b.HasIndex("IdServico");

                    b.ToTable("FuncionarioServico", (string)null);
                });

            modelBuilder.Entity("BarberTip.Entities.Rotina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Dia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdFuncionario")
                        .IsUnique();

                    b.ToTable("Rotinas", (string)null);
                });

            modelBuilder.Entity("BarberTip.Entities.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("Tempo")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Servicos", (string)null);
                });

            modelBuilder.Entity("BarberTip.Entities.Agendamento", b =>
                {
                    b.HasOne("BarberTip.Entities.Cliente", "Cliente")
                        .WithMany("Agendamentos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberTip.Entities.FuncionarioServico", "FuncionarioServico")
                        .WithMany("Agendamentos")
                        .HasForeignKey("IdFuncionarioServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("FuncionarioServico");
                });

            modelBuilder.Entity("BarberTip.Entities.Atividade", b =>
                {
                    b.HasOne("BarberTip.Entities.Agendamento", "Agendamento")
                        .WithOne("Atividade")
                        .HasForeignKey("BarberTip.Entities.Atividade", "IdAgendamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agendamento");
                });

            modelBuilder.Entity("BarberTip.Entities.Endereco", b =>
                {
                    b.HasOne("BarberTip.Entities.Funcionario", "Funcionario")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("BarberTip.Entities.FuncionarioServico", b =>
                {
                    b.HasOne("BarberTip.Entities.Funcionario", "Funcionario")
                        .WithMany("FuncionarioServicos")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberTip.Entities.Servico", "Servico")
                        .WithMany("FuncionarioServicos")
                        .HasForeignKey("IdServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("BarberTip.Entities.Rotina", b =>
                {
                    b.HasOne("BarberTip.Entities.Funcionario", "Funcionario")
                        .WithOne("Rotina")
                        .HasForeignKey("BarberTip.Entities.Rotina", "IdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("BarberTip.Entities.Agendamento", b =>
                {
                    b.Navigation("Atividade")
                        .IsRequired();
                });

            modelBuilder.Entity("BarberTip.Entities.Cliente", b =>
                {
                    b.Navigation("Agendamentos");
                });

            modelBuilder.Entity("BarberTip.Entities.Funcionario", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("FuncionarioServicos");

                    b.Navigation("Rotina")
                        .IsRequired();
                });

            modelBuilder.Entity("BarberTip.Entities.FuncionarioServico", b =>
                {
                    b.Navigation("Agendamentos");
                });

            modelBuilder.Entity("BarberTip.Entities.Servico", b =>
                {
                    b.Navigation("FuncionarioServicos");
                });
#pragma warning restore 612, 618
        }
    }
}
