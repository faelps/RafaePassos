using RafaePassos.Models;
using RafaePassos.Models.Dto;
using System;

namespace RafaePassos.Factory
{
    public static class PessoaFactory
    {
        internal static PessoaDto MontarPessoaDto(Pessoa pessoaModel)
        {
            return new PessoaDto
            {
                Cpf = pessoaModel.Cpf,
                DataNascimento = pessoaModel.DataNascimento,
                Email = pessoaModel.Email,
                Id = pessoaModel.Id,
                Nome = pessoaModel.Nome,
                Sexo = pessoaModel.Sexo,
                Telefone = pessoaModel.Telefone
            };
        }
    }
}
