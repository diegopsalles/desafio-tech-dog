using Desafio.Tech.Dog.ApplicationService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Escola
{
    public class GetEscolaByIdMessage
    {
        [JsonPropertyName("idEscola")]
        public int IdEscola { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("endereco")]
        public EnderecoModel Endereco { get; set; }

        [JsonPropertyName("turmas")]
        public List<TurmaModel> Turmas { get; set; }
    }
}
