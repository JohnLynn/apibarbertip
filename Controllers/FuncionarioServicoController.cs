//utilização de outros namespaces
using BarberTip.Services;//Add() Remove() Update() Find()
using BarberTip.ViewModels;//Design Pattern - MVVM (cria uma camada de dados para a View)
using Microsoft.AspNetCore.Mvc;//trabalhar com AspNet Core MVC

//definição do namespace
namespace BarberTip.Controllers;

[Route("api/funcionarioServicos")]//caminho sub url
[ApiController] //define como APi porque pode ter outras aplicações web

public class FuncionarioServicoController:ControllerBase{
     
    private readonly FuncionarioServicoService _funcionarioServicoService;

    public FuncionarioServicoController(FuncionarioServicoService funcionarioServicoService)
    {
        _funcionarioServicoService = funcionarioServicoService;
    }

    [HttpPost]
    public IActionResult AdicionarFuncionarioServico(AdicionarFuncionarioServicoViewModel dados){
          var funcionarioServico = _funcionarioServicoService.AdicionarFuncionarioServico(dados);
          return Ok(funcionarioServico);
    } 

    [HttpGet]
    public IActionResult ListarFuncionarioServicos(){
        return Ok(_funcionarioServicoService.ListarFuncionarioServicos());
    }
    [HttpGet("{id}")]
    public IActionResult ListarFuncionarioServicoPeloId(int id){
        var funcionarioServico = _funcionarioServicoService.ListarFuncionarioServicosPeloId(id);
        if(funcionarioServico!=null){
            return Ok(funcionarioServico);
        }         
        return NotFound();//Esse é o 404
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarFuncionarioServico(int id,AtualizarFuncionarioServicoViewModel dados){



        if(id != dados.Id){
            return BadRequest("o id informado na URL é diferente do corpo da requisição");
        }
        var funcionarioServico = _funcionarioServicoService.AtualizarFuncionarioServico(dados);
        return Ok(funcionarioServico);
    }
    [HttpDelete("{id}")]
    public IActionResult ExluirFuncionarioServico(int id){
        _funcionarioServicoService.ExcluirFuncionarioServico(id);
        return NoContent(); //204
    }
}