using BarberTip.Entities;

namespace BarberTip.ViewModels;
public class AdicionarEnderecoViewModel{
    public AdicionarEnderecoViewModel(string logradouro, int numero, string bairro, string cidade, string cep, int idFuncionario)
    {
        Logradouro = logradouro;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Cep = cep;
        IdFuncionario = idFuncionario;
    }

    public string Logradouro { get; set; }
    public int Numero{ get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }
    public int IdFuncionario { get; set; } //FK
    
}