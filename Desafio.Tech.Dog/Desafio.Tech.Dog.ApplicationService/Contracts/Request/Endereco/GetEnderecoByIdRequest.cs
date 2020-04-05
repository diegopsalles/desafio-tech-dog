using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Endereco
{
    public class GetEnderecoByIdRequest
    {
        [JsonPropertyName("idEndereco")]
        public int IdEndereco { get; set; }
    }
}
