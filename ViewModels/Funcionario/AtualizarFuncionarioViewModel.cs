using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class AtualizarFuncionarioViewModel{
    public AtualizarFuncionarioViewModel(int id, string nome, int cpf, int telefone, string email, DateTime dataNascimento, string funcao)
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
        Funcao = funcao;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public int Cpf { get; set; }
    public int Telefone { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Funcao { get; set; }
     
}