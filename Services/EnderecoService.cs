using BarberTip.Contexts;
using BarberTip.Entities;
using BarberTip.ViewModels;

namespace BarberTip.Services;

public class EnderecoService
{

    private readonly BarberTipContext _context;

    public EnderecoService(BarberTipContext context)
    {
        _context = context;
    }
    public ListarEnderecoViewModel? AdicionarEndereco(AdicionarEnderecoViewModel dados)
    {

        var endereco = new Endereco
        (   
            dados.Logradouro,
            dados.Numero,
            dados.Bairro,
            dados.Cidade,
            dados.Cep,
            dados.IdFuncionario
        );
        _context.Add(endereco);
        _context.SaveChanges();
        return new ListarEnderecoViewModel
            (
                endereco.Id,
                endereco.Logradouro,
                endereco.Numero,
                endereco.Bairro,
                endereco.Cidade,
                endereco.Cep,
                endereco.IdFuncionario
            );

    }
    public IEnumerable<ListarEnderecoViewModel> ListarEnderecos()
    {
        return _context.Enderecos.Select(e => new ListarEnderecoViewModel(
            e.Id,
            e.Logradouro,
            e.Numero,
            e.Bairro,
            e.Cidade,
            e.Cep,
            e.IdFuncionario
            ));
    }
    public DetalhesEnderecoViewModel? ListarEnderecoPeloId(int id){
       var endereco = _context.Enderecos.Find(id);
       if(endereco!=null){
         return new DetalhesEnderecoViewModel
         (
            endereco.Id,
            endereco.Logradouro,
            endereco.Numero,
            endereco.Bairro,
            endereco.Cidade,
            endereco.Cep,
            endereco.IdFuncionario
         );
       }
         return null;
    } 
    
    public ListarEnderecoViewModel? AtualizarEndereco(AtualizarEnderecoViewModel dados)
    {

        var endereco = _context.Enderecos.Find(dados.Id);
        if (endereco != null)
        {

            endereco.Logradouro = dados.Logradouro;
            endereco.Numero = dados.Numero;
            endereco.Bairro = dados.Bairro;
            endereco.Cidade = dados.Cidade;
            endereco.Cep = dados.Cep;
            endereco.IdFuncionario = dados.IdFuncionario;
            _context.Update(endereco);
            _context.SaveChanges();


        }
        return null;
    }
    public void ExcluirEndereco(int id)
    {

        var endereco = _context.Enderecos.Find(id);
        if (endereco != null)
        {
            _context.Remove(endereco);
            _context.SaveChanges();
        }

    }

}