using BarberTip.Contexts;
using BarberTip.Entities;
using BarberTip.ViewModels;

namespace BarberTip.Services;

public class FuncionarioService
{

    private readonly BarberTipContext _context;

    public FuncionarioService(BarberTipContext context)
    {
        _context = context;
    }
    public ListarFuncionarioViewModel? AdicionarFuncionario(AdicionarFuncionarioViewModel dados)
    {

        var funcionario = new Funcionario
        (
            dados.Nome,
            dados.Cpf,
            dados.Telefone,
            dados.Email,
            dados.DataNascimento,
            dados.Funcao
        );
        _context.Add(funcionario);
        _context.SaveChanges();
        return new ListarFuncionarioViewModel
            (
                funcionario.Id,
                funcionario.Nome,
                funcionario.Cpf,
                funcionario.Telefone,
                funcionario.Email,
                funcionario.DataNascimento,
                funcionario.Funcao
            );

    }
    public IEnumerable<ListarFuncionarioViewModel> ListarFuncionarios()
    {
        return _context.Funcionarios.Select(f => new ListarFuncionarioViewModel(
            f.Id,
            f.Nome,
            f.Cpf,
            f.Telefone,
            f.Email,
            f.DataNascimento,
            f.Funcao
        ));
    }
    public DetalhesFuncionarioViewModel? ListarFuncionarioPeloId(int id){
       var funcionario = _context.Funcionarios.Find(id);
       if(funcionario!=null){
         return new DetalhesFuncionarioViewModel
         (
            funcionario.Id,
            funcionario.Nome,
            funcionario.Cpf,
            funcionario.Telefone,
            funcionario.Email,
            funcionario.DataNascimento,
            funcionario.Funcao
         );
       }
         return null;
    } 

    public ListarFuncionarioViewModel? AtualizarFuncionario(AtualizarFuncionarioViewModel dados)
    {

        var funcionario = _context.Funcionarios.Find(dados.Id);
        if (funcionario != null)
        {

            funcionario.Nome = dados.Nome;
            funcionario.Cpf = dados.Cpf;
            funcionario.Telefone = dados.Telefone;
            funcionario.Email = dados.Email;
            funcionario.DataNascimento = dados.DataNascimento;
            funcionario.Funcao = dados.Funcao;
            _context.Update(funcionario);
            _context.SaveChanges();


        }
        return null;
    }
    public void ExcluirFuncionario(int id)
    {

        var funcionario = _context.Funcionarios.Find(id);
        if (funcionario != null)
        {
            _context.Remove(funcionario);
            _context.SaveChanges();
        }
    }
}