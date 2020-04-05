using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Turma;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Turma
{
    public class GetTurmaByIdResponse : TurmaBaseResponse
    {
        public GetTurmaByIdResponse(bool success, GetTurmaByIdMessage result = null, string error = "")
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public GetTurmaByIdMessage Result { get; set; }
    }
}
