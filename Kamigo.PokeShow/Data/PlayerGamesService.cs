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
        public async Task<List<PokemonGame>> GetPlayerGamesAsync(string playerId)
        {
            var player = await _playerGameRepository.GetPlayerAsync(playerId);
            return player?.GamesOwned ?? new List<PokemonGame>();
        }

        [Authorize]
        public async Task<List<PokemonGame>> AddGameToPlayerAsync(string playerId, int gameId)
        {
            var player = await _playerGameRepository.AddGameToPlayerAsync(playerId, gameId);
            return player.GamesOwned;
        }

        [Authorize]
        public async Task<List<PokemonGame>> DeleteGameFromPlayerAsync(string playerId, int gameId)
        {
            var player = await _playerGameRepository.DeleteGameFromPlayerAsync(playerId, gameId);
            return player.GamesOwned;
        }
    }
}
