using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class AtualizarEnderecoViewModel{
    public AtualizarEnderecoViewModel(int id, string logradouro, int numero, string bairro, string cidade, int cep, int idFuncionario)
    {
        Id = id;
        Logradouro = logradouro;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Cep = cep;
        IdFuncionario = idFuncionario;
    }

    public int Id { get; set; }
    public string Logradouro { get; set; }
    public int Numero{ get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public int Cep { get; set; }
    public int IdFuncionario { get; set; } //FK
     
}