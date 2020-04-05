using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Escola;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola
{
    public class ListEscolaResponse : EscolaBaseResponse
    {
        public ListEscolaResponse(bool success, List<ListEscolaMessage> result = null, string error = "")
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public List<ListEscolaMessage> Result { get; set; }
    }
}
