using Desafio.Tech.Dog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Repository.Configurations
{
    public class TurmaConfigurations
    {
        public static Action<EntityTypeBuilder<Turma>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Turma");
                e.HasKey(x => x.IdTurma);
                e.Property(x => x.IdTurma).HasColumnName("IdTurma").ValueGeneratedOnAdd(); ;
                e.Property(x => x.Nome).IsRequired();
                e.Property(x => x.Capacidade).IsRequired();
                e.HasMany(x => x.Alunos);
            });
        }
    }
}
