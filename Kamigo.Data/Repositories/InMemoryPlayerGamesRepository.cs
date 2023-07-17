using Kamigo.Data.Models;

namespace Kamigo.Data.Repositories
{
    public class InMemoryPlayerGamesRepository : IPlayerGameRepository
    {
        public Task<IEnumerable<PokemonGame>> GetPlayerGamesAsync(string playerId)
        {
            if (string.IsNullOrEmpty(playerId))
                throw new ArgumentNullException(nameof(playerId));

            return Task.FromResult(PokemonGamesList.Games.AsEnumerable());
        }
    }
}
