using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Entities
{
    public class Turma
    {
        public int IdTurma { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }

        public List<Aluno> Alunos { get; set; }


        public void Update(string nome, int capacidade)
        {
            this.Nome = nome;
            this.Capacidade = capacidade;
        }

        public void Add(string nome, int capacidade)
        {
            this.Nome = nome;
            this.Capacidade = capacidade;
        }
    }
}
