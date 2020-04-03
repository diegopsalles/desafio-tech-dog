using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno
{
    public class AddAlunoResponse : AlunoBaseResponse
    {
        public AddAlunoResponse(bool success, int id = 0, string error = "")
        {
            IdAluno = id;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("idAluno")]
        public int IdAluno { get; set; }
    }
}
