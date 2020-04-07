using System;
using Microsoft.EntityFrameworkCore;
using Desafio.Tech.Dog.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.Tech.Dog.Repository.Configurations
{
    public class EnderecoConfigurations
    {
        public static Action<EntityTypeBuilder<Endereco>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Endereco");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
                e.Property(x => x.Logradouro).IsRequired();
                e.Property(x => x.Complemento).IsRequired();
                e.Property(x => x.Bairro).IsRequired();
                e.Property(x => x.Cidade).IsRequired();
                e.Property(x => x.Estado).IsRequired();

                e.HasOne(x => x.Escola);
            });
        }
    }
}
