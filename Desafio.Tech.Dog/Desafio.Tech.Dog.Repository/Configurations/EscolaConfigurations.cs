using Desafio.Tech.Dog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Desafio.Tech.Dog.Repository.Configurations
{
    public class EscolaConfigurations
    {
        public static Action<EntityTypeBuilder<Escola>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Escola");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd(); ;
                e.Property(x => x.Nome).IsRequired();

                e.HasOne(x => x.Endereco);
                e.HasMany(x => x.Turmas);
            });
        }
    }
}
