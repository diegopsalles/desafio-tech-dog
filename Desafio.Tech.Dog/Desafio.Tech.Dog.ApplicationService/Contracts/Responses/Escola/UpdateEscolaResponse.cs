using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Escola;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola
{
    public class UpdateEscolaResponse : EscolaBaseResponse
    {
        public UpdateEscolaResponse(bool success, string error = "", string message = null)
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
