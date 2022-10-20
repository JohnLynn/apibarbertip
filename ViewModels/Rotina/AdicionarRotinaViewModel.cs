using BarberTip.Entities;

namespace BarberTip.ViewModels;
public class AdicionarRotinaViewModel{
    public AdicionarRotinaViewModel(DateTime dia, DateTime hora, int idFuncionario)
    {
        Dia = dia;
        Hora = hora;
        IdFuncionario = idFuncionario;
    }

    public DateTime Dia { get; set; }
    public DateTime Hora { get; set; }
    public int IdFuncionario { get; set; } //FK
    
}