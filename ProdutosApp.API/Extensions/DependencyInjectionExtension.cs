using Microsoft.EntityFrameworkCore;
using ProdutosApp.Domain.Interfaces.Repositories;
using ProdutosApp.Domain.Interfaces.Services;
using ProdutosApp.Domain.Services;
using ProdutosApp.Infra.Data.Contexts;
using ProdutosApp.Infra.Data.Repositories;

namespace ProdutosApp.API.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencyInjection
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("BDProdutosApp")));

            services.AddTransient<ICategoriaDomainService, CategoriaDomainService>();
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            return services;
        }
    }
}
