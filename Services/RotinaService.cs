using BarberTip.Contexts;
using BarberTip.Entities;
using BarberTip.ViewModels;

namespace BarberTip.Services;

public class RotinaService
{

    private readonly BarberTipContext _context;

    public RotinaService(BarberTipContext context)
    {
        _context = context;
    }
    public ListarRotinaViewModel? AdicionarRotina(AdicionarRotinaViewModel dados)
    {

        var rotina = new Rotina
        (
          dados.Dia,
          dados.Hora,
          dados.IdFuncionario
        );
        _context.Add(rotina);
        _context.SaveChanges();
        return new ListarRotinaViewModel
            (
                rotina.Id,
                rotina.Dia,
                rotina.Hora,
                rotina.IdFuncionario
            );

    }
    
    public IEnumerable<ListarRotinaViewModel> ListarRotinas()
    {
        return _context.Rotinas.Select(r => new ListarRotinaViewModel(
            r.Id,
            r.Dia,
            r.Hora,
            r.IdFuncionario
            ));
    }
    public DetalhesRotinaViewModel? ListarRotinasPeloId(int id){
       var rotina = _context.Rotinas.Find(id);
       if(rotina!=null){
         return new DetalhesRotinaViewModel
         (
            rotina.Id,
            rotina.Dia,
            rotina.Hora,
            rotina.IdFuncionario

         );
       }
         return null;
    }   
    public ListarRotinaViewModel? AtualizarRotina(AtualizarRotinaViewModel dados)
    {

        var rotina = _context.Rotinas.Find(dados.Id);
        if (rotina != null)
        {

            rotina.Dia = dados.Dia;
            rotina.Hora = dados.Hora;
            rotina.IdFuncionario = dados.IdFuncionario;
            _context.Update(rotina);
            _context.SaveChanges();


        }
        return null;
    }
    public void ExcluirRotina(int id)
    {

        var rotina = _context.Rotinas.Find(id);
        if (rotina != null)
        {
            _context.Remove(rotina);
            _context.SaveChanges();
        }

    }

}