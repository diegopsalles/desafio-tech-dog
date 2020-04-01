using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Endereco;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Endereco;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Interfaces
{
    public interface IEnderecoApplicationService
    {
        AddEnderecoResponse Add(AddEnderecoRequest request);
        EnderecoResponse Update(AddEnderecoRequest request);
        EnderecoResponse List();
        EnderecoResponse Get(int Id);
    }
}
