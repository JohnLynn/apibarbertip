
namespace BarberTip.ViewModels;

public class AtualizarClienteViewModel{
    public AtualizarClienteViewModel(int id,string nome, string telefone, string email, DateTime dataNascimento)
    {
        Id = id;
        Nome = nome;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
    }

     public int Id { get; set; }
     public string Nome { get; set; }

     public string Telefone { get; set; }
     public string Email{ get; set; }

     public DateTime DataNascimento { get; set; }



}
