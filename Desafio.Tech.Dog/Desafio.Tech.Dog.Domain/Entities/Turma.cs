using System.Collections.Generic;

namespace Desafio.Tech.Dog.Domain.Entities
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public Escola Escola { get; set; }
        public int EscolaId { get; set; }
        public List<Aluno> Alunos { get; set; }
        public void Update(string nome, int capacidade, int escolaId)
        {
            this.Nome = nome;
            this.Capacidade = capacidade;
            this.EscolaId = escolaId;
        }
        public void Add(string nome, int capacidade, int escolaId)
        {
            this.Nome = nome;
            this.Capacidade = capacidade;
            this.EscolaId = escolaId;
        }
    }
}
