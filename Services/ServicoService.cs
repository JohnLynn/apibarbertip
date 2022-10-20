using BarberTip.Contexts;
using BarberTip.Entities;
using BarberTip.ViewModels;

namespace BarberTip.Services;

public class ServicoService
{

    private readonly BarberTipContext _context;

    public ServicoService(BarberTipContext context)
    {
        _context = context;
    }
    public ListarServicoViewModel? AdicionarServico(AdicionarServicoViewModel dados)
    {

        var servico = new Servico
        (
          dados.Nome,
          dados.Valor,
          dados.Tempo
        );
        _context.Add(servico);
        _context.SaveChanges();
        return new ListarServicoViewModel
            (
                servico.Id,
                servico.Nome,
                servico.Valor,
                servico.Tempo
            );

    }
    public IEnumerable<ListarServicoViewModel> ListarServicos()
    {
        return _context.Servicos.Select(s => new ListarServicoViewModel(
            s.Id,
            s.Nome,
            s.Valor,
            s.Tempo
            ));
    }
    public DetalhesServicoViewModel? ListarServicosPeloId(int id){
       var servico = _context.Servicos.Find(id);
       if(servico!=null){
         return new DetalhesServicoViewModel
         (
            servico.Id,
            servico.Nome,
            servico.Valor,
            servico.Tempo
         );
       }
         return null;
    } 
    public ListarServicoViewModel? AtualizarServico(AtualizarServicoViewModel dados)
    {

        var servico = _context.Servicos.Find(dados.Id);
        if (servico != null)
        {

            servico.Nome = dados.Nome;
            servico.Valor = dados.Valor;
            servico.Tempo = dados.Tempo;
            _context.Update(servico);
            _context.SaveChanges();


        }
        return null;
    }
    public void ExcluirServico(int id)
    {

        var servico = _context.Servicos.Find(id);
        if (servico != null)
        {
            _context.Remove(servico);
            _context.SaveChanges();
        }

    }

}