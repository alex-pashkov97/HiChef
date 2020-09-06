using AutoMapper;
using HiChef.Business;
using HiChef.Data;
using HiChef.Data.Interfaces;
using HiChef.Data.Models;
using HiChef.Model.Interfaces;
using HiChef.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace HiChef.Service.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterManagers(this IServiceCollection services)
        {
            return services.AddTransient<IRecipesManager, RecipesManager>();
        }

        public static IServiceCollection RegisterDataAcessLayers(this IServiceCollection services)
        {
            return services.AddTransient<IRecipesDataAcessLayer, RecipesDataAccessLayer>();
        }

        public static IServiceCollection RegisterDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<IRecipesDataAcessLayer, RecipesDataAccessLayer>(options =>
                options.UseSqlServer(configuration.GetConnectionString("AzureSqlServer")));
        }

        public static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
        {
            var configuration = new MapperConfiguration(mc =>
            {
                mc.CreateMap<Recipe, RecipeDataModel>();
                mc.CreateMap<RecipeDataModel, Recipe>();
                mc.CreateMap<Ingredient, IngredientDataModel>();
                mc.CreateMap<IngredientDataModel, Ingredient>();
            });
            IMapper autoMapper = configuration.CreateMapper();

            return services.AddSingleton(autoMapper);
        }
    }
}
