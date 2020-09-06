using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HiChef.Data.Interfaces;
using HiChef.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HiChef.Data
{
    public class RecipesDataAccessLayer : DbContext, IRecipesDataAcessLayer
    {
        private DbSet<RecipeDataModel> Recipes { get; set; }

        public RecipesDataAccessLayer(DbContextOptions<RecipesDataAccessLayer> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public Task<RecipeDataModel> GetRecipe(Guid recipeGuid)
        {
            return Recipes.FirstOrDefaultAsync(r => r.Guid == recipeGuid);
        }


        public async Task<List<RecipeDataModel>> GetUserRecipes(Guid userGuid)
        {
            return (await Recipes.Include(r => r.User).ToListAsync())
                .Where(r => r.User.Guid == userGuid)
                .ToList();
        }

        public async Task<RecipeDataModel> SaveRecipe(RecipeDataModel recipe)
        {
            recipe.CreationDate = DateTime.Now;

            await Recipes.AddAsync(recipe);
            await this.SaveChangesAsync();

            return recipe;
        }

        public async Task<RecipeDataModel> UpdateRecipe(RecipeDataModel recipe)
        {
            Recipes.Update(recipe);
            await this.SaveChangesAsync();

            return recipe;
        }

        public async Task DeleteRecipe(Guid recipeGuid)
        {
            Recipes.Remove(await Recipes.FindAsync(recipeGuid));
            await this.SaveChangesAsync();
        }
    }
}
