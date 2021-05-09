using RafaePassos.Models;
using RafaePassos.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RafaePassos.Service.Interface
{
    public interface IPessoaService
    {
        Task<List<Pessoa>> ObterPessoas();
        Task<Request> Cadastrar(PessoaDto pessoa);
        Task<Request> Editar(PessoaDto pessoa);
        Task<PessoaDto> ObterPorId(int id);
        Task<Request> Deletar(int id);
    }
}
