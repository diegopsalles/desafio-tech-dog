using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Entities
{
    public class Escola
    {
        public int IdEscola { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        public List<Turma> Turmas { get; set; }

    }
}
