using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno
{
    public class ListAlunoResponse : AlunoBaseResponse
    {
        public ListAlunoResponse(bool success, List<ListAlunoMessage> result = null, string error= "")
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public List<ListAlunoMessage> Result { get; set; }
    }
}
