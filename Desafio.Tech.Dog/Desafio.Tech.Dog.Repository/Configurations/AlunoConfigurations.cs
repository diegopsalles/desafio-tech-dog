using System;
using Microsoft.EntityFrameworkCore;
using Desafio.Tech.Dog.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.Tech.Dog.Repository.Configurations
{
    public class AlunoConfigurations
    {
        public static Action<EntityTypeBuilder<Aluno>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Aluno");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd(); ;
                e.Property(x => x.Nome).IsRequired();
                e.Property(x => x.DataDeNascimento).IsRequired();

                e.HasOne(x => x.Turma);
            });
        }
    }
}
