using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola
{
    public class DeleteEscolaResponse : EscolaBaseResponse
    {
        public DeleteEscolaResponse(bool success, string message = "", string error = "")
        {
            Success = success;
            Message = message;
            if (!success)
                SetError(error);
        }
    }
}
