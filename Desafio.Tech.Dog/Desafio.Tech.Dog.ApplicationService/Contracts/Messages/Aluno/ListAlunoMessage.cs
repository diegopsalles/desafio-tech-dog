using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno
{
    public class ListAlunoMessage
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public Turma IdTurma { get; set; }
    }
}
