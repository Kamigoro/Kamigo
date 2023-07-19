using Kamigo.Data.Models;

namespace Kamigo.Data.Repositories
{
    public interface IPlayerRepository
    {
        Task<Player> GetPlayerAsync(string playerId);
        Task<Player> AddGamesToPlayerAsync(string playerId, int[] gamesIds);
        Task<Player> DeleteGameFromPlayerAsync(string playerId, int gameId);
    }
}
