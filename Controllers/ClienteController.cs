/*
   ***PROTOCOLO - HTTP (comunicação)***
      Verbos
      POST - inserir
      PUT  - alterar
      GET  - pegar
      DELETE - apagar
*/

using BarberTip.Services;
using BarberTip.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BarberTip.Controllers;

//Rota - SubCaminho
[Route("api/clientes")]
[ApiController] 
public class ClienteController:ControllerBase{
     
    private readonly ClienteService _clienteService;

    public ClienteController(ClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpPost]
    public IActionResult AdicionarCliente(AdicionarClienteViewModel dados){
          var cliente = _clienteService.AdicionarCliente(dados);
          return Ok(cliente);
    } 

    [HttpGet]
    public IActionResult ListarClientes(){
        return Ok(_clienteService.ListarClientes());
    }
    [HttpGet("{id}")]
    public IActionResult ListarClientePeloId(int id){
        var cliente = _clienteService.ListarClientePeloId(id);
        if(cliente!=null){
            return Ok(cliente);
        }         
        return NotFound();//Esse é o 404
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarCliente(int id,AtualizarClienteViewModel dados){



        if(id != dados.Id){
            return BadRequest("o id informado na URL é diferente do corpo da requisição");
        }
        var cliente = _clienteService.AtualizarCliente(dados);
        return Ok(cliente);
    }
    [HttpDelete("{id}")]
    public IActionResult ExluirCliente(int id){
        _clienteService.ExcluirCliente(id);
        return NoContent(); //204
    }

    

}


