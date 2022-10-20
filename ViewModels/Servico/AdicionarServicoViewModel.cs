using BarberTip.Entities;

namespace BarberTip.ViewModels;
public class AdicionarServicoViewModel{
    public AdicionarServicoViewModel(string nome, decimal valor, DateTime tempo)
    {
        Nome = nome;
        Valor = valor;
        Tempo = tempo;
    }

    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public DateTime Tempo { get; set; }
    
}