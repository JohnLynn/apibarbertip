
namespace BarberTip.ViewModels;

public class AdicionarClienteViewModel{
    public AdicionarClienteViewModel(string nome,string telefone,string email,DateTime dataNascimento)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
    }

  
     public string Nome { get; set; }

     public string Telefone { get; set; }
     public string Email{ get; set; }

     public DateTime DataNascimento { get; set; }



}
