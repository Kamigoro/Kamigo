using Kamigo.Data.Entities;
using Kamigo.Data.Models;
using Microsoft.Azure.Cosmos;

namespace Kamigo.Data.Repositories
{
    public class CosmosPlayerGameRepository : IPlayerRepository
    {
        private readonly Container _playerGamesContainer;
        public CosmosPlayerGameRepository(Container playerGamesContainer)
        {
            _playerGamesContainer = playerGamesContainer;
        }

        public async Task<Player> GetPlayerAsync(string playerId)
        {
            try
            {
                var response = await _playerGamesContainer.ReadItemAsync<PlayerEntity>(playerId, new PartitionKey("player"));
                var playerEntity = response.Resource;
                return Player.FromPlayerEntity(playerEntity);
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<Player> AddGamesToPlayerAsync(string playerId, int[] gamesIds)
        {
            var player = await GetPlayerAsync(playerId);
            if(player is null)
            {
                var playerEntity = new PlayerEntity
                {
                    Id = playerId,
                    GamesOwnedIds = new HashSet<int>(gamesIds)
                };
                await _playerGamesContainer.CreateItemAsync(playerEntity);
                return Player.FromPlayerEntity(playerEntity);
            }
            else
            {
                var playerEntity = Player.ToPlayerEntity(player);
                foreach(var gameId in gamesIds)
                {
                    playerEntity.GamesOwnedIds.Add(gameId);
                }
                await _playerGamesContainer.UpsertItemAsync(playerEntity);
                return Player.FromPlayerEntity(playerEntity);
            }
        }
    }
}
