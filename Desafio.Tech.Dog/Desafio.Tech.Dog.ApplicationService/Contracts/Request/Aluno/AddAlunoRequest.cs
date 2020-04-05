using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno
{
    public class AddAlunoRequest
    {
        [JsonPropertyName("alunoMessage")]
        public AddAlunoMessage AlunoMessage { get; set; }
    }
}
