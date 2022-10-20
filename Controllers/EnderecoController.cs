//utilização de outros namespaces
using BarberTip.Services;//Add() Remove() Update() Find()
using BarberTip.ViewModels;//Design Pattern - MVVM (cria uma camada de dados para a View)
using Microsoft.AspNetCore.Mvc;//trabalhar com AspNet Core MVC

//definição do namespace
namespace BarberTip.Controllers;

[Route("api/enderecos")]//caminho sub url
[ApiController] //define como APi porque pode ter outras aplicações web

public class EnderecoController:ControllerBase{
     
    private readonly EnderecoService _enderecoService;

    public EnderecoController(EnderecoService enderecoService)
    {
        _enderecoService = enderecoService;
    }

    [HttpPost]
    public IActionResult AdicionarEndereco(AdicionarEnderecoViewModel dados){
          var endereco = _enderecoService.AdicionarEndereco(dados);
          return Ok(endereco);
    } 

    [HttpGet]
    public IActionResult ListarEnderecos(){
        return Ok(_enderecoService.ListarEnderecos());
    }
    [HttpGet("{id}")]
    public IActionResult ListarEnderecoPeloId(int id){
        var endereco = _enderecoService.ListarEnderecoPeloId(id);
        if(endereco!=null){
            return Ok(endereco);
        }         
        return NotFound();//Esse é o 404
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarEndereco(int id,AtualizarEnderecoViewModel dados){



        if(id != dados.Id){
            return BadRequest("o id informado na URL é diferente do corpo da requisição");
        }
        var endereco = _enderecoService.AtualizarEndereco(dados);
        return Ok(endereco);
    }
    [HttpDelete("{id}")]
    public IActionResult ExluirEndereco(int id){
        _enderecoService.ExcluirEndereco(id);
        return NoContent(); //204
    }

    

}