using Desafio.Tech.Dog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Repository.Configurations
{
    public class AlunoConfigurations
    {
        public static Action<EntityTypeBuilder<Aluno>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Aluno");
                e.HasKey(x => x.IdAluno);
                e.Property(x => x.IdAluno).HasColumnName("IdAluno").ValueGeneratedOnAdd();;
                e.Property(x => x.Nome).IsRequired();
                e.Property(x => x.DataDeNascimento).IsRequired();
                e.Property(x => x.IdTurma).IsRequired();
                //e.HasOne(x => x.Turma);

            });
        }
    }
}
