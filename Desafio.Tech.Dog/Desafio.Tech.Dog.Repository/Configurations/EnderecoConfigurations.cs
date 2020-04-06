using Desafio.Tech.Dog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Repository.Configurations
{
    public class EnderecoConfigurations
    {
        public static Action<EntityTypeBuilder<Endereco>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Endereco");
                e.HasKey(x => x.IdEndereco);
                e.Property(x => x.IdEndereco).HasColumnName("IdEndereco").ValueGeneratedOnAdd(); ;
                e.Property(x => x.IdEscola).IsRequired();
                e.Property(x => x.Logradouro).IsRequired();
                e.Property(x => x.Complemento).IsRequired();
                e.Property(x => x.Bairro).IsRequired();
                e.Property(x => x.Cidade).IsRequired();
                e.Property(x => x.Estado).IsRequired();

            });
        }
    }
}
