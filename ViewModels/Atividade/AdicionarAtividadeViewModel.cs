using BarberTip.Entities;

namespace BarberTip.ViewModels;
public class AdicionarAtividadeViewModel{
    public AdicionarAtividadeViewModel(int status, int idAgendamento)
    {

        Status = status;
        IdAgendamento = idAgendamento;
    }

    public int Status { get; set; }
    public int IdAgendamento { get; set; } //FK
    
}