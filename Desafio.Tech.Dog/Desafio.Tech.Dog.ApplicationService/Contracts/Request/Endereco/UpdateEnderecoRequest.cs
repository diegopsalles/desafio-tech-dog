using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Endereco
{
    public class UpdateEnderecoRequest
    {
        [JsonPropertyName("idEndereco"), Required]
        public int IdEndereco { get; set; }
        [JsonPropertyName("logradouro"), Required]
        public string Logradouro { get; set; }
        [JsonPropertyName("complemento"), Required]
        public string Complemento { get; set; }
        [JsonPropertyName("bairro"), Required]
        public string Bairro { get; set; }
        [JsonPropertyName("cidade"), Required]
        public string Cidade { get; set; }
        [JsonPropertyName("estado"), Required]
        public string Estado { get; set; }
    }
}
