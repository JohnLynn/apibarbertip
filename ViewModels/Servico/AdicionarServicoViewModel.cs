using BarberTip.Entities;

namespace BarberTip.ViewModels;
public class AdicionarServicoViewModel{
    public AdicionarServicoViewModel(string nome, string valor, DateTime tempo)
    {
        Nome = nome;
        Valor = valor;
        Tempo = tempo;
    }

    public string Nome { get; set; }
    public string Valor { get; set; }
    public DateTime Tempo { get; set; }
    
}