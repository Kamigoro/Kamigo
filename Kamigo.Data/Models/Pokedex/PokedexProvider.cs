using Kamigo.Data.Models.Pokedex.Gen1;
using Microsoft.Extensions.Caching.Memory;

namespace Kamigo.Data.Models.Pokedex
{
    public class PokedexProvider
    {
        private readonly IMemoryCache _memoryCache;
        public PokedexProvider(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public async Task<NationalPokedex> GetPokedexAsync(int generation, string region)
        {
            var key = $"{generation}-{region}";
            if (_memoryCache.TryGetValue(key, out NationalPokedex pokedex))
            {
                return pokedex;
            }
            else
            {
                pokedex = await GetPokedexFromLocalStorageAsync(generation, region);
                _memoryCache.Set(key, pokedex);
                return pokedex;
            }
        }

        private async Task<NationalPokedex> GetPokedexFromLocalStorageAsync(int generation, string region)
        {
            switch(generation)
            {
                case 1:
                    return await Gen1PokedexProvider.GetPokedexAsync();
                default:
                    return null;
            }
        }
    }
}
