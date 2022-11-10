using System.Text;
using BarberTip.Contexts;//é o banco
using BarberTip.Entities;//classes de entidades
using BarberTip.ViewModels; //camada de dados da view
using Microsoft.EntityFrameworkCore;//framework de ORM

namespace BarberTip.Services;

public class AgendamentoService
{

    private readonly BarberTipContext _context;

    public AgendamentoService(BarberTipContext context)
    {
        _context = context;
    }
    public DetalhesAgendamentoViewModel AdicionarAgendamento(AdicionarAgendamentoViewModel dados)
    {
        var agendamento = new Agendamento
        (
          dados.Data,
          dados.Hora,
          dados.IdCliente,
          dados.IdFuncionarioServico
        );
        _context.Add(agendamento);
        _context.SaveChanges();
        
        return new DetalhesAgendamentoViewModel
            (
                agendamento.Id,
                agendamento.Data,
                agendamento.Hora,
                agendamento.IdCliente,
                agendamento.IdFuncionarioServico
            );

    }
    public IEnumerable<ListarAgendamentoViewModel> ListarAgendamentos(){
         
         return _context.Agendamentos.Select(a=> new ListarAgendamentoViewModel(                                     a.Id,
            a.Data,
            a.Hora,
            a.IdCliente,
            a.IdFuncionarioServico
            ));

    }
    public DetalhesAgendamentoViewModel? ListarAgendamentosPeloId(int id){
       var agendamento = _context.Agendamentos.Find(id);
       if(agendamento!=null){
         return new DetalhesAgendamentoViewModel
         (                       
            agendamento.Id,
            agendamento.Data,
            agendamento.Hora,
            agendamento.IdCliente,
            agendamento.IdFuncionarioServico
         );
       }
         return null;
    } 

    public ListarAgendamentoViewModel? AtualizarAgendamento(AtualizarAgendamentoViewModel dados)
    {

        var agendamento = _context.Agendamentos.Find(dados.Id);
        if (agendamento != null)
        {

            agendamento.Data = dados.Data;
            agendamento.Hora = dados.Hora;
            agendamento.IdCliente = dados.IdCliente;
            agendamento.IdFuncionarioServico = dados.IdFuncionarioServico;
            _context.Update(agendamento);
            _context.SaveChanges();


        }
        return null;
    }
    public void ExcluirAgendamento(int id)
    {

        var agendamento = _context.Agendamentos.Find(id);
        if (agendamento != null)
        {
            _context.Remove(agendamento);
            _context.SaveChanges();
        }

    }

}



