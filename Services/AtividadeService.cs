using BarberTip.Contexts;
using BarberTip.Entities;
using BarberTip.ViewModels;

namespace BarberTip.Services;

public class AtividadeService
{

    private readonly BarberTipContext _context;

    public AtividadeService(BarberTipContext context)
    {
        _context = context;
    }
    public ListarAtividadeViewModel? AdicionarAtividade(AdicionarAtividadeViewModel dados)
    {

        var atividade = new Atividade
        (
          dados.Status,
          dados.IdAgendamento
        );
        _context.Add(atividade);
        _context.SaveChanges();
        return new ListarAtividadeViewModel
            (
                atividade.Id,
                atividade.Status,
                atividade.IdAgendamento
            );

    }
    public IEnumerable<ListarAtividadeViewModel> ListarAtividades()
    {
        return _context.Atividades.Select(at => new ListarAtividadeViewModel(
                                     at.Id,
                                     at.Status,
                                     at.IdAgendamento
                                    ));
    }
    public DetalhesAtividadeViewModel? ListarAtividadePeloId(int id){
       var atividade = _context.Atividades.Find(id);
       if(atividade!=null){
         return new DetalhesAtividadeViewModel
         (
            atividade.Id,
            atividade.Status,
            atividade.IdAgendamento
         );
       }
         return null;
    } 

    public ListarAtividadeViewModel? AtualizarAtividade(AtualizarAtividadeViewModel dados)
    {

        var atividade = _context.Atividades.Find(dados.Id);
        if (atividade != null)
        {
            atividade.Status = dados.Status;
            atividade.IdAgendamento = dados.IdAgendamento;
            _context.Update(atividade);
            _context.SaveChanges();


        }
        return null;
    }
    public void ExcluirAtividade(int id)
    {

        var atividade = _context.Atividades.Find(id);
        if (atividade != null)
        {
            _context.Remove(atividade);
            _context.SaveChanges();
        }

    }

}