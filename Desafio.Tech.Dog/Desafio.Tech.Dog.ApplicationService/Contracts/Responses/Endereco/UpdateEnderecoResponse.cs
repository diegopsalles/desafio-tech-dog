using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Endereco;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Endereco
{
    public class UpdateEnderecoResponse : EnderecoBaseResponse
    {
        public UpdateEnderecoResponse(bool success, string error = "", string message = null)
        {
            Message = message;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
