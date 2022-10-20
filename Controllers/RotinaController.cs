//utilização de outros namespaces
using BarberTip.Services;//Add() Remove() Update() Find()
using BarberTip.ViewModels;//Design Pattern - MVVM (cria uma camada de dados para a View)
using Microsoft.AspNetCore.Mvc;//trabalhar com AspNet Core MVC

//definição do namespace
namespace BarberTip.Controllers;

[Route("api/rotinas")]//caminho sub url
[ApiController] //define como APi porque pode ter outras aplicações web

public class RotinaController:ControllerBase{
     
    private readonly RotinaService _rotinaService;

    public RotinaController(RotinaService rotinaService)
    {
        _rotinaService = rotinaService;
    }

    [HttpPost]
    public IActionResult AdicionarRotina(AdicionarRotinaViewModel dados){
          var rotina = _rotinaService.AdicionarRotina(dados);
          return Ok(rotina);
    } 

    [HttpGet]
    public IActionResult ListarRotinas(){
        return Ok(_rotinaService.ListarRotinas());
    }
    [HttpGet("{id}")]
    public IActionResult ListarRotinaPeloId(int id){
        var rotina = _rotinaService.ListarRotinasPeloId(id);
        if(rotina!=null){
            return Ok(rotina);
        }         
        return NotFound();//Esse é o 404
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarRotina(int id,AtualizarRotinaViewModel dados){



        if(id != dados.Id){
            return BadRequest("o id informado na URL é diferente do corpo da requisição");
        }
        var rotina = _rotinaService.AtualizarRotina(dados);
        return Ok(rotina);
    }
    [HttpDelete("{id}")]
    public IActionResult ExluirRotina(int id){
        _rotinaService.ExcluirRotina(id);
        return NoContent(); //204
    }

    

}