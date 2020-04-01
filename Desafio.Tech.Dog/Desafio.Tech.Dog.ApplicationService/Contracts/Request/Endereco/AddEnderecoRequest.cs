using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Endereco;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Endereco
{
    public class AddEnderecoRequest
    {
        public AddEnderecoMessage EnderecoMessage { get; set; }
    }
}
