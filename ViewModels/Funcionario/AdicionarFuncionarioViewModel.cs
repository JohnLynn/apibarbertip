using BarberTip.Entities;

namespace BarberTip.ViewModels;
public class AdicionarFuncionarioViewModel{
    public AdicionarFuncionarioViewModel(string nome, string cpf, string telefone, string email, DateTime dataNascimento, string funcao)
    {
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
        Funcao = funcao;
    }

    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Funcao { get; set; }
    
}