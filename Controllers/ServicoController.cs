//utilização de outros namespaces
using BarberTip.Services;//Add() Remove() Update() Find()
using BarberTip.ViewModels;//Design Pattern - MVVM (cria uma camada de dados para a View)
using Microsoft.AspNetCore.Mvc;//trabalhar com AspNet Core MVC

//definição do namespace
namespace BarberTip.Controllers;

[Route("api/servicos")]//caminho sub url
[ApiController] //define como APi porque pode ter outras aplicações web


public class ServicoController:ControllerBase{
     
    private readonly ServicoService _servicoService;

    public ServicoController(ServicoService servicoService)
    {
        _servicoService = servicoService;
    }

    [HttpPost]
    public IActionResult AdicionarServico(AdicionarServicoViewModel dados){
          var servico = _servicoService.AdicionarServico(dados);
          return Ok(servico);
    } 

    [HttpGet]
    public IActionResult ListarServicos(){
        return Ok(_servicoService.ListarServicos());
    }
    [HttpGet("{id}")]
    public IActionResult ListarServicoPeloId(int id){
        var servico = _servicoService.ListarServicosPeloId(id);
        if(servico!=null){
            return Ok(servico);
        }         
        return NotFound();//Esse é o 404
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarServico(int id,AtualizarServicoViewModel dados){



        if(id != dados.Id){
            return BadRequest("o id informado na URL é diferente do corpo da requisição");
        }
        var servico = _servicoService.AtualizarServico(dados);
        return Ok(servico);
    }
    [HttpDelete("{id}")]
    public IActionResult ExluirServico(int id){
        _servicoService.ExcluirServico(id);
        return NoContent(); //204
    }
}