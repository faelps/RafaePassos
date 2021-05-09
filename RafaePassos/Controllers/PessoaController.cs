using Microsoft.AspNetCore.Mvc;
using RafaePassos.Models.Dto;
using RafaePassos.Service.Interface;
using System.Threading.Tasks;

namespace RafaePassos.Controllers
{
    public class PessoaController : BaseController
    {
        private readonly IPessoaService pessoaService;
        public PessoaController(IPessoaService pessoaService)
        {
            this.pessoaService = pessoaService;
        }
        public async Task<IActionResult> Index()
        {
            var pessoas = await pessoaService.ObterPessoas();
            return View(pessoas);
        }

        public IActionResult CadastrarPessoa()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CadastrarPessoa(PessoaDto pessoa)
        {
            var resposta = await pessoaService.Cadastrar(pessoa);
            if (resposta.Sucesso)
                MensagemSucesso = resposta.mensagem;
            else
                MensagemErro = resposta.mensagem;
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> EditarPessoa(int id)
        {
            var pessoa = await pessoaService.ObterPorId(id);
            return View(pessoa);
        }
        [HttpPost]
        public async Task<IActionResult> EditarPessoa(PessoaDto pessoa)
        {
            var resposta = await pessoaService.Editar(pessoa);
            if (resposta.Sucesso)
                MensagemSucesso = resposta.mensagem;
            else
                MensagemErro = resposta.mensagem;
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            var pessoa = await pessoaService.ObterPorId(id);
            return View(pessoa);
        }

        public async Task<IActionResult> Deletar(int id)
        {
            var resposta = await pessoaService.Deletar(id);
            if (resposta.Sucesso)
                MensagemSucesso = resposta.mensagem;
            else
                MensagemErro = resposta.mensagem;
            return RedirectToAction("Index");
        }

    }
}
