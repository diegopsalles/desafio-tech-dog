using Desafio.Tech.Dog.ApplicationService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno
{
    public class UpdateAlunoRequest
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public TurmaModel Turma { get; set; }
    }

}
