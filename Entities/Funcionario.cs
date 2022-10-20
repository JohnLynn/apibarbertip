using BarberTip.Contexts;
namespace BarberTip.Entities;
public class Funcionario{
    public Funcionario(string nome, int cpf, int telefone, string email, DateTime dataNascimento, string funcao)
    {
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
        Funcao = funcao;
    }

    public int Id { get; set; } //PK
    public string Nome { get; set; }
    public int Cpf { get; set; }
    public int Telefone { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Funcao { get; set; }
    public Rotina Rotina { get; set; } = null!; // (0,1)
    public ICollection<Endereco> Enderecos { get; set; }=null!; // (1,n)
    public ICollection<FuncionarioServico> FuncionarioServicos { get; set; } = null!; // (0,n)
}