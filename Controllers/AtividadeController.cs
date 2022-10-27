//utilização de outros namespaces
using BarberTip.Services;//Add() Remove() Update() Find()
using BarberTip.ViewModels;//Design Pattern - MVVM (cria uma camada de dados para a View)
using Microsoft.AspNetCore.Mvc;//trabalhar com AspNet Core MVC

//definição do namespace
namespace BarberTip.Controllers;

[Route("api/atividades")]//caminho sub url
[ApiController] //define como APi porque pode ter outras aplicações web

public class AtividadeController:ControllerBase{
     
    private readonly AtividadeService _atividadeService;

    public AtividadeController(AtividadeService atividadeService)
    {
        _atividadeService = atividadeService;
    }

    [HttpPost]
    public IActionResult AdicionarAtividade(AdicionarAtividadeViewModel dados){
          var atividade = _atividadeService.AdicionarAtividade(dados);
          return Ok(atividade);
    } 

    [HttpGet]
    public IActionResult ListarAtividades(){
        return Ok(_atividadeService.ListarAtividades());
    }
    [HttpGet("{id}")]
    public IActionResult ListarAtividadePeloId(int id){
        var atividade = _atividadeService.ListarAtividadePeloId(id);
        if(atividade!=null){
            return Ok(atividade);
        }         
        return NotFound();//Esse é o 404
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarAtividade(int id,AtualizarAtividadeViewModel dados){



        if(id != dados.Id){
            return BadRequest("o id informado na URL é diferente do corpo da requisição");
        }
        var atividade = _atividadeService.AtualizarAtividade(dados);
        return Ok(atividade);
    }
    [HttpDelete("{id}")]
    public IActionResult ExluirAtividade(int id){
        _atividadeService.ExcluirAtividade(id);
        return NoContent(); //204
    }
}