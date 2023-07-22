using Kamigo.Data.Models;

namespace Kamigo.Data.Repositories
{
    public interface IPlayerRepository
    {
        Task<Player> GetPlayerAsync(string playerId);
        Task<Player> AddGameToPlayerAsync(string playerId, int gamesId);
        Task<Player> DeleteGameFromPlayerAsync(string playerId, int gameId);
    }
}
