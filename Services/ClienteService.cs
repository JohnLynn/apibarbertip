using BarberTip.Contexts;
using BarberTip.Entities;
using BarberTip.ViewModels;

namespace BarberTip.Services;

public class ClienteService{
    
    private readonly BarberTipContext _context;

    public ClienteService(BarberTipContext context)
    {
        _context = context;
    }

    public DetalhesClienteViewModel AdicionarCliente(AdicionarClienteViewModel dados){

        var cliente = new Cliente
        (
            dados.Nome,
            dados.Telefone,
            dados.Email,
            dados.DataNascimento
        );
        _context.Add(cliente);
        _context.SaveChanges();

        return new DetalhesClienteViewModel
        (
               cliente.Id,
               cliente.Nome,
               cliente.Email,
               cliente.Telefone,
               cliente.DataNascimento
        );
    }
    public IEnumerable<ListarClienteViewModel> ListarClientes(){
         
         return _context.Clientes.Select(c=> new ListarClienteViewModel(
            c.Id,
            c.Nome,
            c.Telefone
            ));

    }

    public DetalhesClienteViewModel? ListarClientePeloId(int id){
       var cliente = _context.Clientes.Find(id);
       if(cliente!=null){
         return new DetalhesClienteViewModel
         (
            cliente.Id,
            cliente.Nome,
            cliente.Telefone,
            cliente.Email,
            cliente.DataNascimento
         );
       }
         return null;
    }  

    public DetalhesClienteViewModel? AtualizarCliente(AtualizarClienteViewModel dados){        
          var cliente = _context.Clientes.Find(dados.Id);
          if(cliente != null){
                cliente.Nome = dados.Nome;
                cliente.Email = dados.Email;
                cliente.DataNascimento = dados.DataNascimento;
                cliente.Telefone= dados.Telefone;                
                _context.Update(cliente);
                _context.SaveChanges();
                return new DetalhesClienteViewModel(cliente.Id,cliente.Nome,
                cliente.Telefone,
                cliente.Email,cliente.DataNascimento);
          }
          return null;
    }
    public void ExcluirCliente(int id){
        var cliente = _context.Clientes.Find(id);
        if(cliente != null){
            _context.Remove(cliente);
            _context.SaveChanges();
        }
    }
}
    


