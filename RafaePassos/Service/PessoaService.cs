using Microsoft.Extensions.Configuration;
using RafaePassos.Factory;
using RafaePassos.Models;
using RafaePassos.Models.Dto;
using RafaePassos.Repository.CRUD;
using RafaePassos.Repository.Interface;
using RafaePassos.Service.Interface;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace RafaePassos.Service
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository pessoaRepository;
        private readonly string urlRafaelApi;
        public PessoaService(IPessoaRepository pessoaRepository)
        {
            this.pessoaRepository = pessoaRepository;
          
        }

        public async Task<Request> Cadastrar(PessoaDto pessoa)
        {
            return await pessoaRepository.Cadastrar(pessoa);
        }

        public async Task<Request> Deletar(int id)
        {
            return await pessoaRepository.Deletar(id);
        }

        public async Task<Request> Editar(PessoaDto pessoa)
        {
            return await pessoaRepository.Editar(pessoa);
        }

        public async Task<List<Pessoa>> ObterPessoas()
        {
            return await pessoaRepository.ObterPessoas();
        }

        public async Task<PessoaDto> ObterPorId(int id)
        {
            var pessoaModel = await pessoaRepository.ObterPorId(id);
            var pessoaVm = PessoaFactory.MontarPessoaDto(pessoaModel);
            return pessoaVm;
        }
    }
}
