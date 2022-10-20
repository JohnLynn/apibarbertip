using BarberTip.Contexts;
using BarberTip.ViewModels;

namespace BarberTip.Entities;

public class Cliente{
    public Cliente(string nome, string telefone, string email, DateTime dataNascimento)
    {
       
        Nome = nome;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
    }

    public int Id { get; set; } //PK
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email{ get; set; }
    public DateTime DataNascimento { get; set; }

    public ICollection<Agendamento> Agendamentos { get; set; }=null!; // (0,n)

}
