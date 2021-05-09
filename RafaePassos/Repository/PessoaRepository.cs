using Microsoft.Extensions.Configuration;
using RafaePassos.Models;
using RafaePassos.Models.Dto;
using RafaePassos.Repository.CRUD;
using RafaePassos.Repository.Interface;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RafaePassos.Repository
{
    public class PessoaRepository : ConsumirRepository, IPessoaRepository
    {
        private Uri Url { get; set; }
        public PessoaRepository(IConfiguration config)
        {
            Url = new Uri(config["UrlRafaelApi"]);
        }
        public async Task<Request> Cadastrar(PessoaDto pessoa)
        {
            var rest = $"api/Pessoa/cadastrar/{pessoa}";
            var resultado = await Enviar<Request>(Url, rest, Method.POST, pessoa);
            return resultado;
        }

        public async Task<Request> Deletar(int id)
        {
            var rest = $"api/Pessoa/excluir/{id}";
            var resultado = await Buscar<Request>(Url, rest, Method.GET);
            return resultado;
        }

        public async Task<Request> Editar(PessoaDto pessoa)
        {
            var rest = $"api/Pessoa/editar/{pessoa}";
            var resultado = await Enviar<Request>(Url, rest, Method.PUT, pessoa);
            return resultado;
        }

        public async Task<List<Pessoa>> ObterPessoas()
        {
            var rest = $"api/Pessoa/obterPessoas";
            var resultado = await Buscar<List<Pessoa>>(Url, rest, Method.GET);
            return resultado;
        }

        public async Task<Pessoa> ObterPorId(int id)
        {
            var rest = $"api/Pessoa/obterPorId/{id}";
            var resultado = await Buscar<Pessoa>(Url, rest, Method.GET);
            return resultado;
        }
    }
}
