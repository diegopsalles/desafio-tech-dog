using System.Collections.Generic;

namespace Desafio.Tech.Dog.Domain.Entities
{
    public class Escola
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int EderecoId { get; set; }
        public List<Turma> Turmas { get; set; }
        public void Update(string nome)
        {
            this.Nome = nome;
        }
        public void Add(string nome)
        {
            this.Nome = nome;
        }
    }
}
