using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Endereco
{
    public class AddEnderecoResponse
    {
        [JsonPropertyName("idEndereco")]
        public int IdEndereco { get; set; }
    }
}
