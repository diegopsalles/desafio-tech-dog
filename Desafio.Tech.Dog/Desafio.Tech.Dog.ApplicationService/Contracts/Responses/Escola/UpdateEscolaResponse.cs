using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Escola;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola
{
    public class UpdateEscolaResponse : EscolaBaseResponse
    {
        public UpdateEscolaResponse(bool success, UpdateEscolaMessage result = null, string error = "", string message = null)
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public UpdateEscolaMessage Result { get; set; }
    }
}
