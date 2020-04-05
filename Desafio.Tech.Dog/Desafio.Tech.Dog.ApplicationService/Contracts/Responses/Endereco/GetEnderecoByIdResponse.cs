using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Endereco;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Endereco
{
    public class GetEnderecoByIdResponse : EnderecoBaseResponse
    {
        public GetEnderecoByIdResponse(bool success, GetEnderecoByIdMessage result = null, string error = "")
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public GetEnderecoByIdMessage Result { get; set; }
    }
}
