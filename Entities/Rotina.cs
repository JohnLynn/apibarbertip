using BarberTip.Contexts;
namespace BarberTip.Entities;
public class Rotina{
    public Rotina(DateTime dia, DateTime hora, int idFuncionario)
    {
        Dia = dia;
        Hora = hora;
        IdFuncionario = idFuncionario;
    }

    public int Id { get; set; } //PK
    public DateTime Dia { get; set; }
    public DateTime Hora { get; set; }
    public int IdFuncionario { get; set; } //FK
    public Funcionario Funcionario { get; set; } = null!; // (1,1)
}