//utilização de outros namespaces
using BarberTip.Services;//Add() Remove() Update() Find()
using BarberTip.ViewModels;//Design Pattern - MVVM (cria uma camada de dados para a View)
using Microsoft.AspNetCore.Mvc;//trabalhar com AspNet Core MVC

//definição do namespace
namespace BarberTip.Controllers;

[Route("api/funcionarios")]//caminho sub url
[ApiController] //define como APi porque pode ter outras aplicações web

public class FuncionarioController:ControllerBase{
     
    private readonly FuncionarioService _funcionarioService;

    public FuncionarioController(FuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    [HttpPost]
    public IActionResult AdicionarFuncionario(AdicionarFuncionarioViewModel dados){
          var funcionario = _funcionarioService.AdicionarFuncionario(dados);
          return Ok(funcionario);
    } 
    
    [HttpGet]
    public IActionResult ListarFuncionarios(){
        return Ok(_funcionarioService.ListarFuncionarios());
    }
    [HttpGet("{id}")]
    public IActionResult ListarFuncionarioPeloId(int id){
        var funcionario = _funcionarioService.ListarFuncionarioPeloId(id);
        if(funcionario!=null){
            return Ok(funcionario);
        }         
        return NotFound();//Esse é o 404
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarFuncionario(int id,AtualizarFuncionarioViewModel dados){



        if(id != dados.Id){
            return BadRequest("o id informado na URL é diferente do corpo da requisição");
        }
        var funcionario = _funcionarioService.AtualizarFuncionario(dados);
        return Ok(funcionario);
    }
    [HttpDelete("{id}")]
    public IActionResult ExluirFuncionario(int id){
        _funcionarioService.ExcluirFuncionario(id);
        return NoContent(); //204
    }
}