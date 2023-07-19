using Kamigo.Data.Entities;

namespace Kamigo.Data.Models
{
    public class Player
    {
        public string Id { get; set; }
        public List<PokemonGame> GamesOwned { get; set; }

        public static Player FromPlayerEntity(PlayerEntity entity)
        {
            return new Player
            {
                Id = entity.Id,
                GamesOwned = entity.GamesOwnedIds
                .Select(gameId => PokemonGamesList.Games.First(g => g.Id == gameId))
                .ToList()
            };
        }

        public static PlayerEntity ToPlayerEntity(Player player)
        {
            return new PlayerEntity
            {
                Id = player.Id,
                GamesOwnedIds = player.GamesOwned.Select(g => g.Id).ToHashSet()
            };
        }
    }
}
