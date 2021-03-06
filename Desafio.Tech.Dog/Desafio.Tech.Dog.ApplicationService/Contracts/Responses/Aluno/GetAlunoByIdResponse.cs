﻿using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno
{
    public class GetAlunoByIdResponse : AlunoBaseResponse
    {
        public GetAlunoByIdResponse(bool success, GetAlunoByIdMessage result = null, string error = "")
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public GetAlunoByIdMessage Result { get; set; }
    }
}
