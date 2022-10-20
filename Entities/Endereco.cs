using BarberTip.Contexts;
namespace BarberTip.Entities;
public class Endereco{
    public Endereco(string logradouro, int numero, string bairro, string cidade, int cep, int idFuncionario)
    {
        Logradouro = logradouro;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Cep = cep;
        IdFuncionario = idFuncionario;
    }

    public int Id { get; set; } //PK
    public string Logradouro { get; set; }
    public int Numero{ get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public int Cep { get; set; }
    public int IdFuncionario { get; set; } //FK
    public Funcionario Funcionario { get; set; } = null!; // (1,1)
}
