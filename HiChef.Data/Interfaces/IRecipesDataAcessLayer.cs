using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HiChef.Data.Models;

namespace HiChef.Data.Interfaces
{
    public interface IRecipesDataAcessLayer
    {
        Task<RecipeDataModel> GetRecipe(Guid recipeGuid);

        Task<List<RecipeDataModel>> GetUserRecipes(Guid userGuid);

        Task<RecipeDataModel> SaveRecipe(RecipeDataModel recipe);

        Task<RecipeDataModel> UpdateRecipe(RecipeDataModel recipe);

        Task DeleteRecipe(Guid recipeGuid);
    }
}
