using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Endereco;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Endereco
{
    public class UpdateEnderecoResponse : EnderecoBaseResponse
    {
        public UpdateEnderecoResponse(bool success, UpdateEnderecoMessage result = null, string error = "", string message = null)
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public UpdateEnderecoMessage Result { get; set; }
    }
}
