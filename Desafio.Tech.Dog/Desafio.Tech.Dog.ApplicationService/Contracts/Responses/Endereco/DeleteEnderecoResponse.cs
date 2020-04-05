using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Endereco
{
    public class DeleteEnderecoResponse : EnderecoBaseResponse
    {
        public DeleteEnderecoResponse(bool success, string message = "", string error = "")
        {
            Success = success;
            Message = message;
            if (!success)
                SetError(error);
        }
    }
}
