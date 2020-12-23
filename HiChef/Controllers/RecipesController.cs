using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HiChef.Model.Interfaces;
using HiChef.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace HiChef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase, IRecipesManager
    {
        private readonly IRecipesManager _recipesManager;
        
        public RecipesController(IRecipesManager recipesManager)
        {
            _recipesManager = recipesManager ?? throw new ArgumentNullException(nameof(recipesManager));
        }

        [HttpGet("{recipeGuid}")]
        public Task<Recipe> GetRecipe(Guid recipeGuid)
        {
            return _recipesManager.GetRecipe(recipeGuid);
        }

        [HttpGet("user-recipes/{userGuid}")]
        public Task<List<Recipe>> GetUserRecipes(Guid userGuid)
        {
            return _recipesManager.GetUserRecipes(userGuid);
        }

        [HttpPost("save-recipe")]
        public Task<Recipe> SaveRecipe(Recipe recipe)
        {
            return _recipesManager.SaveRecipe(recipe);
        }

        [HttpPut("update-recipe")]
        public Task<Recipe> UpdateRecipe(Recipe recipe)
        {
            return _recipesManager.UpdateRecipe(recipe);
        }

        [HttpDelete("{recipeGuid}")]
        public Task DeleteRecipe(Guid recipeGuid)
        {
            return _recipesManager.DeleteRecipe(recipeGuid);
        }
    }
}
