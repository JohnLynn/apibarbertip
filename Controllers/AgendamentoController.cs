//utilização de outros namespaces
using BarberTip.Services;//Add() Remove() Update() Find()
using BarberTip.ViewModels;//Design Pattern - MVVM (cria uma camada de dados para a View)
using Microsoft.AspNetCore.Mvc;//trabalhar com AspNet Core MVC

//definição do namespace
namespace BarberTip.Controllers;

[Route("api/agendamentos")]//caminho sub url
[ApiController] //define como APi porque pode ter outras aplicações web
public class AgendamentoController:ControllerBase{

    private readonly AgendamentoService _agendamentoService;

    public AgendamentoController(AgendamentoService agendamentoService)
    {
        _agendamentoService = agendamentoService;
    }
    [HttpPost]
    public IActionResult AdicionarAgendamento(AdicionarAgendamentoViewModel dados){
        var agendamento = _agendamentoService.AdicionarAgendamento(dados);
        return Ok(agendamento); //Status Http 200.

    }
    [HttpGet]
    public IActionResult ListarAgendamentos(){
        return Ok(_agendamentoService.ListarAgendamentos());
    }

    [HttpGet("{idFuncionarioServico}")]
    public IActionResult ListarAgendamentosPeloFuncionarioServico(int idFuncionarioServico){
        var atividade = _agendamentoService.ListarAgendamentosPeloFuncionarioServico(idFuncionarioServico);
        if(atividade!=null){
            return Ok(atividade);
        }         
        return NotFound();//Esse é o 404
    }
    [HttpGet("{idCliente}")]
    public IActionResult ListarAgendamentosPeloCliente(int idCliente){
        var atividade = _agendamentoService.ListarAgendamentosPeloCliente(idCliente);
        if(atividade!=null){
            return Ok(atividade);
        }         
        return NotFound();//Esse é o 404
    }
    
}
