using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HiChef.Data.Interfaces;
using HiChef.Data.Models;
using HiChef.Model.Interfaces;
using HiChef.Model.Models;

namespace HiChef.Business
{
    public class RecipesManager : IRecipesManager
    {
        private readonly IRecipesDataAcessLayer _recipesDataAcessLayer;
        private readonly IMapper _mapper;

        public RecipesManager(
            IRecipesDataAcessLayer recipesDataAcessLayer,
            IMapper mapper)
        {
            _recipesDataAcessLayer = recipesDataAcessLayer ?? throw new ArgumentNullException(nameof(recipesDataAcessLayer));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Recipe> GetRecipe(Guid recipeGuid)
        {
            if (recipeGuid == Guid.Empty)
            {
                throw new ArgumentException(nameof(recipeGuid));
            }

            return _mapper.Map<Recipe>(await _recipesDataAcessLayer.GetRecipe(recipeGuid));
        }


        public async Task<List<Recipe>> GetUserRecipes(Guid userGuid)
        {
            if (userGuid == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(userGuid));
            }

            return _mapper.Map<List<Recipe>>(await _recipesDataAcessLayer.GetUserRecipes(userGuid));
        }

        public async Task<Recipe> SaveRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            var recipeDataModel = _mapper.Map<RecipeDataModel>(recipe);

            return _mapper.Map<Recipe>(await _recipesDataAcessLayer.SaveRecipe(recipeDataModel));
        }

        public async Task<Recipe> UpdateRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            var recipeDataModel = _mapper.Map<RecipeDataModel>(recipe);

            return _mapper.Map<Recipe>(await _recipesDataAcessLayer.UpdateRecipe(recipeDataModel));
        }

        public Task DeleteRecipe(Guid recipeGuid)
        {
            if (recipeGuid == Guid.Empty)
            {
                throw new ArgumentException(nameof(recipeGuid));
            }

            return _recipesDataAcessLayer.DeleteRecipe(recipeGuid);
        }
    }
}
