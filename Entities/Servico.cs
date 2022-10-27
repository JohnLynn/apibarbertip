using BarberTip.Contexts;
namespace BarberTip.Entities;

public class Servico{
    public Servico(string nome, string valor, DateTime tempo)
    {
        Nome = nome;
        Valor = valor;
        Tempo = tempo;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Valor { get; set; }
    public DateTime Tempo { get; set; }
    public ICollection<FuncionarioServico> FuncionarioServicos { get; set; }=null!; // (0,n)
   
}