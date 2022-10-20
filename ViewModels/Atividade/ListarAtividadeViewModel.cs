using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class ListarAtividadeViewModel{
    public ListarAtividadeViewModel(int id, int status, int idAgendamento)
    {
        Id = id;
        Status = status;
        IdAgendamento = idAgendamento;
    }

    public int Id { get; set; }
    public int Status { get; set; }
    public int IdAgendamento { get; set; } //FK
     
}