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

        public int IdTurma { get; set; }
        public Turma Turma { get; set; }

        public void Update(string nome, DateTime dataDeNascimento, int idTurma)
        {
           this.Nome = nome;
           this.DataDeNascimento = dataDeNascimento;
           this.IdTurma = idTurma;
        }
        public void Add(string nome, DateTime dataDeNascimento, int idTurma)
        {
            this.Nome = nome;
            this.DataDeNascimento = dataDeNascimento;
            this.IdTurma = idTurma;
        }
    }
}
