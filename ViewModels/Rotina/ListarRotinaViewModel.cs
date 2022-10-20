using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class ListarRotinaViewModel{
    public ListarRotinaViewModel(int id, DateTime dia, DateTime hora, int idFuncionario)
    {
        Id = id;
        Dia = dia;
        Hora = hora;
        IdFuncionario = idFuncionario;
    }

    public int Id { get; set; }
    public DateTime Dia { get; set; }
    public DateTime Hora { get; set; }
    public int IdFuncionario { get; set; } //FK
     
}