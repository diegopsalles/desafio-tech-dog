﻿using Desafio.Tech.Dog.ApplicationService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Endereco
{
    public class ListEnderecoMessage
    {
        [JsonPropertyName("idEndereco")]
        public int IdEndereco { get; set; }
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }
        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }
        [JsonPropertyName("cidade")]
        public string Cidade { get; set; }
        [JsonPropertyName("estado")]
        public string Estado { get; set; }
        [JsonPropertyName("idEscola")]
        public int IdEscola { get; set; }
    }
}
