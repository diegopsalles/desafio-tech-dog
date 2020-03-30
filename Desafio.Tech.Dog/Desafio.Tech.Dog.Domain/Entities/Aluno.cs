using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Entities
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public Turma Turma { get; set; }
    }
}
