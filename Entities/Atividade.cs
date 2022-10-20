using BarberTip.Contexts;
namespace BarberTip.Entities;
public class Atividade{
    public Atividade(int status, int idAgendamento)
    {
        Status = status;
        IdAgendamento = idAgendamento;
    }

    public int Id { get; set; } //PK
    public int Status { get; set; }
    public int IdAgendamento { get; set; } //FK
    public Agendamento Agendamento { get; set; } = null!; // (1,1)
}