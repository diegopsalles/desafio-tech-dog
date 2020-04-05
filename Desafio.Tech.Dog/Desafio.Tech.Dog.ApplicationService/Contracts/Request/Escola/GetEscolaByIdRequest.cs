using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Escola
{
    public class GetEscolaByIdRequest
    {
        [JsonPropertyName("idEscola")]
        public int IdEscola { get; set; }
    }
}
