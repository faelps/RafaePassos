using RafaePassos.Models;
using RafaePassos.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RafaePassos.Repository.Interface
{
    public interface IPessoaRepository
    {
        Task<Request> Cadastrar(PessoaDto pessoa);
        Task<Request> Deletar(int id);
        Task<Request> Editar(PessoaDto pessoa);
        Task<List<Pessoa>> ObterPessoas();
        Task<Pessoa> ObterPorId(int id);
    }
}
