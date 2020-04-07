using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno
{
    public class DeleteAlunoRequest
    {
        [JsonPropertyName("idAluno"), Required]
        public int IdAluno { get; set; }
    }
}
