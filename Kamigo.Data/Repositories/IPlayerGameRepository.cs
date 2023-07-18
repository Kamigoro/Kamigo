using Kamigo.Data.Models;

namespace Kamigo.Data.Repositories
{
    public interface IPlayerGameRepository
    {
        Task<IEnumerable<PokemonGame>> GetPlayerGamesAsync(string playerId);
        Task<IEnumerable<PokemonGame>> AddGamesToPlayerAsync(string playerId, int[] gamesIds);
    }
}
