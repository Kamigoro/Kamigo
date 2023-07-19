using Kamigo.Data.Models;
using Kamigo.Data.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace Kamigo.PokeShow.Data
{
    public class PlayerGamesService
    {
        private readonly IPlayerRepository _playerGameRepository;
        public PlayerGamesService(IPlayerRepository playerGameRepository)
        {
            _playerGameRepository = playerGameRepository;
        }

        [Authorize]
        public async Task<IEnumerable<PokemonGame>> GetPlayerGamesAsync(string playerId)
        {
            var player = await _playerGameRepository.GetPlayerAsync(playerId);
            return player?.GamesOwned ?? Enumerable.Empty<PokemonGame>();
        }

        [Authorize]
        public async Task<IEnumerable<PokemonGame>> AddGamesToPlayerAsync(string playerId, int[] gamesIds)
        {
            var player = await _playerGameRepository.AddGamesToPlayerAsync(playerId, gamesIds);
            return player.GamesOwned;
        }
    }
}
