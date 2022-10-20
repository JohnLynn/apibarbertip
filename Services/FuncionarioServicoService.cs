using BarberTip.Contexts;
using BarberTip.Entities;
using BarberTip.ViewModels;

namespace BarberTip.Services;

public class FuncionarioServicoService
{

    private readonly BarberTipContext _context;

    public FuncionarioServicoService(BarberTipContext context)
    {
        _context = context;
    }
    public ListarFuncionarioServicoViewModel? AdicionarFuncionarioServico(AdicionarFuncionarioServicoViewModel dados)
    {

        var funcionarioServico = new FuncionarioServico
        (
          dados.IdFuncionario,
          dados.IdServico

        );
        _context.Add(funcionarioServico);
        _context.SaveChanges();
        return new ListarFuncionarioServicoViewModel
            (
                funcionarioServico.Id,
                funcionarioServico.IdFuncionario,
                funcionarioServico.IdServico
            );

    }
    
    public IEnumerable<ListarFuncionarioServicoViewModel> ListarFuncionarioServicos()
    {
        return _context.FuncionarioServicos.Select(fs => new ListarFuncionarioServicoViewModel(
                                     fs.Id,
                                     fs.IdFuncionario,
                                     fs.IdServico
                                    ));
    }
    public DetalhesFuncionarioServicoViewModel? ListarFuncionarioServicosPeloId(int id){
       var funcionarioServico = _context.FuncionarioServicos.Find(id);
       if(funcionarioServico!=null){
         return new DetalhesFuncionarioServicoViewModel
         (
            funcionarioServico.Id,
            funcionarioServico.IdFuncionario,
            funcionarioServico.IdServico

         );
       }
         return null;
    }     
    public ListarFuncionarioServicoViewModel? AtualizarFuncionarioServico(AtualizarFuncionarioServicoViewModel dados)
    {

        var funcionarioServico = _context.FuncionarioServicos.Find(dados.Id);
        if (funcionarioServico != null)
        {

            funcionarioServico.IdFuncionario = dados.IdFuncionario;
            funcionarioServico.IdServico = dados.IdServico;
            _context.Update(funcionarioServico);
            _context.SaveChanges();


        }
        return null;
    }
    public void ExcluirFuncionarioServico(int id)
    {

        var funcionarioServico = _context.FuncionarioServicos.Find(id);
        if (funcionarioServico != null)
        {
            _context.Remove(funcionarioServico);
            _context.SaveChanges();
        }

    }

}