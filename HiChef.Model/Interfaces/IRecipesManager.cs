using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HiChef.Model.Models;

namespace HiChef.Model.Interfaces
{
    public interface IRecipesManager
    {
        Task<Recipe> GetRecipe(Guid recipeGuid);

        Task<List<Recipe>> GetUserRecipes(Guid userGuid);

        Task<Recipe> SaveRecipe(Recipe recipe);

        Task<Recipe> UpdateRecipe(Recipe recipe);

        Task DeleteRecipe(Guid recipeGuid);
    }
}
