using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Models
{
    public class EscolaModel
    {
        [JsonPropertyName("idEscola")]
        public int IdEscola { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }
}
