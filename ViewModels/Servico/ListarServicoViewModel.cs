using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class ListarServicoViewModel{
    public ListarServicoViewModel(int id, string nome, string valor, DateTime tempo)
    {
        Id = id;
        Nome = nome;
        Valor = valor;
        Tempo = tempo;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Valor { get; set; }
    public DateTime Tempo { get; set; }

}