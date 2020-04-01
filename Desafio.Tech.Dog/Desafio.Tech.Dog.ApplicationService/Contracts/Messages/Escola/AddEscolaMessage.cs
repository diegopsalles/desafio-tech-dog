using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Escola
{
    public class AddEscolaMessage
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }
}
