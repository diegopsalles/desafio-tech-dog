using Desafio.Tech.Dog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Desafio.Tech.Dog.Repository.Configurations
{
    public class TurmaConfigurations
    {
        public static Action<EntityTypeBuilder<Turma>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Turma");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd(); ;
                e.Property(x => x.Nome).IsRequired();
                e.Property(x => x.Capacidade).IsRequired();

                e.HasOne(x => x.Escola);
                e.HasMany(x => x.Alunos);

            });
        }
    }
}
