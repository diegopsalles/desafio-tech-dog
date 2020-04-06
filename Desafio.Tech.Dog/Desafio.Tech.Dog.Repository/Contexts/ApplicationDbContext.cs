using Desafio.Tech.Dog.Domain.Entities;
using Desafio.Tech.Dog.Repository.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace Desafio.Tech.Dog.Repository.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var migrationsAssembly = typeof(ApplicationDbContext).GetTypeInfo().Assembly.GetName().Name;
            string strConnection = @"Server = MYSQL5025.site4now.net; Database = db_a5644e_desafio; Uid = a5644e_desafio; Pwd = 290665Diego*";
            optionsBuilder.UseMySql(strConnection, x => x.MigrationsAssembly(migrationsAssembly));
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity(AlunoConfigurations.ConfigureMap());
            modelBuilder.Entity(EnderecoConfigurations.ConfigureMap());
            modelBuilder.Entity(EscolaConfigurations.ConfigureMap());
            modelBuilder.Entity(TurmaConfigurations.ConfigureMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Escola> Escola { get; set; }
        public DbSet<Turma> Turma { get; set; }
    }
}
