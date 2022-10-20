using BarberTip.Entities;

namespace BarberTip.ViewModels;
public class AdicionarAgendamentoViewModel{
    public AdicionarAgendamentoViewModel(DateTime data, DateTime hora, int idCliente, int idFuncionarioServico)
    {
        Data = data;
        Hora = hora;
        IdCliente = idCliente;
        IdFuncionarioServico = idFuncionarioServico;
    }

    public DateTime Data { get; set; }
    public DateTime Hora { get; set; }
    public int IdCliente { get; set; } //FK
    public int IdFuncionarioServico { get; set; } //FK
    
}