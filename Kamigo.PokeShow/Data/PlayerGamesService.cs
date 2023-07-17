using Kamigo.Data.Models;
using Kamigo.Data.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace Kamigo.PokeShow.Data
{
    public class PlayerGamesService
    {
        private readonly IPlayerGameRepository _playerGameRepository;
        public PlayerGamesService(IPlayerGameRepository playerGameRepository)
        {
            _playerGameRepository = playerGameRepository;
        }

        [Authorize]
        public async Task<IEnumerable<PokemonGame>> GetPlayerGamesAsync(string playerId)
        {
            return await _playerGameRepository.GetPlayerGamesAsync(playerId);
        }
    }
}
