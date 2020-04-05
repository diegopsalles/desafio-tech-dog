using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno
{
    public class GetAlunoByIdRequest 
    {
        [JsonPropertyName("idAluno")]
        public int IdAluno { get; set; }
    }
}
