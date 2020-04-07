using Desafio.Tech.Dog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Repository.Configurations
{
    public class EscolaConfigurations
    {
        public static Action<EntityTypeBuilder<Escola>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Escola");
                e.HasKey(x => x.IdEscola);
                e.Property(x => x.IdEscola).HasColumnName("IdEscola").ValueGeneratedOnAdd(); ;
                e.Property(x => x.Nome).IsRequired();
                e.HasOne(x => x.Endereco).WithOne(y => y.Escola).HasForeignKey<Endereco>(z => z.IdEscola);
                e.HasMany(x => x.Turmas).WithOne(y => y.IdTurma).HasForeignKey<Turma>(z => z.IdTurma);
            });
        }
    }
}
