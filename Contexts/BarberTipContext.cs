//Para a classe usar o Framework
using Microsoft.EntityFrameworkCore;
using BarberTip.Entities;
using BarberTip.EntityConfigurations;
//Entity Framework = ORM
//Mapeamento Objeto-Relacional

//Classe é um conjunto de objetos.
//Herança - Pai e um Filho
//O Filho herda do Pai

namespace BarberTip.Contexts;
public class BarberTipContext:DbContext{

    //Definimos uma propriedade que irá configuração
    //Aplica as configuração = ConnectionString
    //IConfiguration - Injeção de Dependência.
    //Animal a = new Animal(); - não injetado
    //Animal _a; - injetado.
     private readonly IConfiguration _configuration;
    public BarberTipContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    //Definir uma classe que será mapeada
    //Lambda
    public DbSet<Agendamento> Agendamentos=>Set<Agendamento>();
    public DbSet<Atividade> Atividades=>Set<Atividade>();
    public DbSet<Cliente> Clientes=>Set<Cliente>();
    public DbSet<Endereco> Enderecos=>Set<Endereco>();
    public DbSet<Funcionario> Funcionarios=>Set<Funcionario>();
    public DbSet<FuncionarioServico> FuncionarioServicos=>Set<FuncionarioServico>();
    public DbSet<Rotina> Rotinas=>Set<Rotina>();
    public DbSet<Servico> Servicos=>Set<Servico>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

          optionsBuilder.UseSqlServer(_configuration.GetConnectionString("BarberTip"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
       
       modelBuilder.ApplyConfiguration(new AgendamentoConfigurations());
       modelBuilder.ApplyConfiguration(new AtividadeConfigurations());
       modelBuilder.ApplyConfiguration(new ClienteConfigurations());
       modelBuilder.ApplyConfiguration(new EnderecoConfigurations());
       modelBuilder.ApplyConfiguration(new FuncionarioConfigurations());
       modelBuilder.ApplyConfiguration(new FuncionarioServicoConfigurations());
       modelBuilder.ApplyConfiguration(new RotinaConfigurations());
       modelBuilder.ApplyConfiguration(new ServicoConfigurations());

    }
}