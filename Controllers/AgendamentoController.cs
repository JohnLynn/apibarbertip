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
        var agendamento = _agendamentoService.ListarAgendamentosPeloFuncionarioServico(idFuncionarioServico);
        if(agendamento!=null){
            return Ok(agendamento);
        }         
        return NotFound();//Esse é o 404
    }

    [HttpGet("{idCliente}")]
    public IActionResult ListarAgendamentosPeloCliente(int idCliente){
        var agendamento = _agendamentoService.ListarAgendamentosPeloCliente(idCliente);
        if(agendamento!=null){
            return Ok(agendamento);
        }         
        return NotFound();//Esse é o 404
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarAgendamento(int id,AtualizarAgendamentoViewModel dados){

        if(id != dados.Id){
            return BadRequest("o id informado na URL é diferente do corpo da requisição");
        }
        var agendamento = _agendamentoService.AtualizarAgendamento(dados);
        return Ok(agendamento);
    }

    [HttpDelete("{id}")]
    public IActionResult ExluirAgendamento(int id){
        _agendamentoService.ExcluirAgendamento(id);
        return NoContent(); //204
    }
}