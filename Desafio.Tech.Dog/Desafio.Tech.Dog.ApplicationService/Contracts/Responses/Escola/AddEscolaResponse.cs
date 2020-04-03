using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola
{
    public class AddEscolaResponse : EscolaBaseResponse
    {
        public AddEscolaResponse(bool success, int id = 0, string error = "")
        {
            IdEscola = id;
            Success = success;
            if (!success)
                SetError(error);
        }
        [JsonPropertyName("idEscola")]
        public int IdEscola { get; set; }
    }
}
