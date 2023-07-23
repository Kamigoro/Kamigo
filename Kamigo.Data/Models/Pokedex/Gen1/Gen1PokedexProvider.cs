using System.Reflection;
using System.Text.Json;

namespace Kamigo.Data.Models.Pokedex.Gen1
{
    public static class Gen1PokedexProvider
    {
        public static async Task<NationalPokedex> GetPokedexAsync()
        {
            var filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Models\Pokedex\Gen1\pokedex-red-blue-yellow.json");
            //Read from a json file and return a list of PokedexEntry
            using (StreamReader r = new StreamReader(filePath))
            {
                var json = await r.ReadToEndAsync();
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                List<PokedexEntry> items = JsonSerializer.Deserialize<List<PokedexEntry>>(json, options);
                return new NationalPokedex { Entries = items };
            }
        }
    }
}
