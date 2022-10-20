using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class AtualizarAgendamentoViewModel{
    public AtualizarAgendamentoViewModel(int id, DateTime data, DateTime hora, int idCliente, int idFuncionarioServico)
    {
        Id = id;
        Data = data;
        Hora = hora;
        IdCliente = idCliente;
        IdFuncionarioServico = idFuncionarioServico;
    }

    public int Id { get; set; }
    public DateTime Data { get; set; }
    public DateTime Hora { get; set; }
    public int IdCliente { get; set; } //FK
    public int IdFuncionarioServico { get; set; } //FK
     
}