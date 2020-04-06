using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Entities
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string  Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Escola Escola { get; set; }
        public int IdEscola { get; set; }

        public void Update(string logradouro, string complemento, string bairro, string cidade, string estado)
        {
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }
        public void Add(string logradouro, string complemento, string bairro, string cidade, string estado)
        {
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }
    }
}
