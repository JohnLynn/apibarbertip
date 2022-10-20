using BarberTip.Entities;

namespace BarberTip.ViewModels;
public class AdicionarFuncionarioServicoViewModel{
    public AdicionarFuncionarioServicoViewModel(int idFuncionario, int idServico)
    {
        IdFuncionario = idFuncionario;
        IdServico = idServico;
    }

    public int IdFuncionario { get; set; } //FK
    public int IdServico { get; set; } //FK
    
}