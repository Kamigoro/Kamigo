using Kamigo.Data.Models;

namespace Kamigo.Data.Repositories
{
    public class InMemoryPlayerGamesRepository : IPlayerGameRepository
    {
        private Dictionary<string, List<int>> GamesOwnedByPlayers = new Dictionary<string, List<int>>();
        public async Task<IEnumerable<PokemonGame>> AddGamesToPlayerAsync(string playerId, int[] gamesIds)
        {
            if(GamesOwnedByPlayers.TryGetValue(playerId, out var games))
            {
                // Add only games that are not already owned by the player
                foreach(var gameId in gamesIds)
                {
                    if(!games.Contains(gameId))
                    {
                        games.Add(gameId);
                    }
                }
            }
            else
            {
                GamesOwnedByPlayers.Add(playerId, new List<int>(gamesIds));
            }
            var gamesOwned = PokemonGamesList.Games.Where(g => GamesOwnedByPlayers[playerId].Contains(g.Id));
            return gamesOwned;
        }

        public Task<IEnumerable<PokemonGame>> GetPlayerGamesAsync(string playerId)
        {
            if (string.IsNullOrEmpty(playerId))
                throw new ArgumentNullException(nameof(playerId));

            if (!GamesOwnedByPlayers.ContainsKey(playerId))
                return Task.FromResult(new List<PokemonGame>().AsEnumerable());

            return Task.FromResult(PokemonGamesList.Games.Where(g => GamesOwnedByPlayers[playerId].Contains(g.Id)));
        }
    }
}
