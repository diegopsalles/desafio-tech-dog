using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola
{
    public class AddEscolaResponse
    {
        [JsonPropertyName("idEscola")]
        public int IdEscola { get; set; }
    }
}
