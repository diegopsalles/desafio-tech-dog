using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Escola;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola
{
    public class GetEscolaByIdResponse : EscolaBaseResponse
    {
        public GetEscolaByIdResponse(bool success, GetEscolaByIdMessage result = null, string error = "")
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public GetEscolaByIdMessage Result { get; set; }
    }
}
