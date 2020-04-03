using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Endereco
{
    public class AddEnderecoResponse : EnderecoBaseResponse
    {
        public AddEnderecoResponse(bool success, int id = 0, string error = "")
        {
            IdEndereco = id;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("idEndereco")]
        public int IdEndereco { get; set; }
    }
}
