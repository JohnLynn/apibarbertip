using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class AtualizarFuncionarioServicoViewModel{
    public AtualizarFuncionarioServicoViewModel(int id, int idFuncionario, int idServico)
    {
        Id = id;
        IdFuncionario = idFuncionario;
        IdServico = idServico;
    }

    public int Id { get; set; }
    public int IdFuncionario { get; set; } //FK
    public int IdServico { get; set; } //FK
     
}