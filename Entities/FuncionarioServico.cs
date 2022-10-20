using BarberTip.Contexts;
namespace BarberTip.Entities;
public class FuncionarioServico{
    public FuncionarioServico(int idFuncionario, int idServico)
    {
        IdFuncionario = idFuncionario;
        IdServico = idServico;
    }

    public int Id { get; set; } //PK
    public int IdFuncionario { get; set; } //FK
    public int IdServico { get; set; } //FK
    public ICollection<Agendamento> Agendamentos { get; set; } = null!; // (0,n)
    public Servico Servico { get; set; }=null!; // (1,1)
    public Funcionario Funcionario { get; set; }=null!; // (1,1)
}