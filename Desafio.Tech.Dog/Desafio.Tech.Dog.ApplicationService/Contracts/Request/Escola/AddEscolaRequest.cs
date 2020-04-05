using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Escola;
using Desafio.Tech.Dog.Domain.Entities;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Escola
{
    public class AddEscolaRequest
    {
        [JsonPropertyName("escolaMessage")]
        public AddEscolaMessage EscolaMessage { get; set; }
    }
}
