using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno
{
    public class ListAlunoResponse
    {
        public List<ListAlunoMessage> ListAlunos { get; set; }
    }
}
