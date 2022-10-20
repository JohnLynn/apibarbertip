using BarberTip.Contexts;
namespace BarberTip.Entities;
public class Agendamento{
    public Agendamento(DateTime data, DateTime hora, int idCliente, int idFuncionarioServico)
    {
        Data = data;
        Hora = hora;
        IdCliente = idCliente;
        IdFuncionarioServico = idFuncionarioServico;
    }

    public int Id { get; set; } //PK
    public DateTime Data { get; set; }
    public DateTime Hora { get; set; }
    public int IdCliente { get; set; } //FK
    public int IdFuncionarioServico { get; set; } //FK
    public Cliente Cliente { get; set; } = null!; // (1,1)
    public FuncionarioServico FuncionarioServico { get; set; } = null!; // (1,1) 
    public Atividade Atividade { get; set; } = null!; // (1,1)  
}