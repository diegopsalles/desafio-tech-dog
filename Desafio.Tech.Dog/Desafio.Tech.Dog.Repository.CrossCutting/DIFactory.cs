using System;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Desafio.Tech.Dog.ApplicationService.Services;
using Desafio.Tech.Dog.Domain.Contracts.Repositories;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Service;
using Desafio.Tech.Dog.Repository.Repositories;


namespace Desafio.Tech.Dog.Repository.CrossCutting
{
    public static class DIFactory
    {
        public static void InvokeDIFactory(this IServiceCollection services)
        {

            services.InvokeDIApplication();
            services.InvokeDIDomainService();
            services.InvokeDIRepository();

        }
        private static void InvokeDIRepository(this IServiceCollection services)
        {
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEscolaRepository, EscolaRepository>();
            services.AddScoped<ITurmaRepository, TurmaRepository>();
        }
        private static void InvokeDIApplication(this IServiceCollection services)
        {

            services.AddScoped<IAlunoApplicationService, AlunoApplicationService>();
            services.AddScoped<IEscolaApplicationService, EscolaApplicationService>();
            services.AddScoped<IEnderecoApplicationService, EnderecoApplicationService>();
            services.AddScoped<ITurmaApplicationService, TurmaApplicationService>();
        }
        private static void InvokeDIDomainService(this IServiceCollection services)
        {
            services.AddScoped<IAlunoDomainService, AlunoDomainService>();
            services.AddScoped<IEscolaDomainService, EscolaDomainService>();
            services.AddScoped<IEnderecoDomainService, EnderecoDomainService>();
            services.AddScoped<ITurmaDomainService, TurmaDomainService>();
        }

        public static void ConfigEntityFramework(this IServiceCollection services)
        {
            string strConnection = @"Server=ecommerce-allied-db1.cqpou5y4xe1k.us-east-1.rds.amazonaws.com;Port=3306;Database=db_p_oi;Uid=usr_oi;Pwd=BNV73g5U;persistsecurityinfo=True;SslMode=none;";

            services.AddDbContext<ApplicationDbContext>(o => o.UseMySql(strConnection));
        }
    }
}
