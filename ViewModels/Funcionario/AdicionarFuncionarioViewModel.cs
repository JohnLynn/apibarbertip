using BarberTip.Entities;

namespace BarberTip.ViewModels;
public class AdicionarFuncionarioViewModel{
    public AdicionarFuncionarioViewModel(string nome, int cpf, int telefone, string email, DateTime dataNascimento, string funcao)
    {
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
        Funcao = funcao;
    }

    public string Nome { get; set; }
    public int Cpf { get; set; }
    public int Telefone { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Funcao { get; set; }
    
}