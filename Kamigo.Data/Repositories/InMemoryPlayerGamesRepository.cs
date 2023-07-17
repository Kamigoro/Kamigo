using Kamigo.Data.Models;

namespace Kamigo.Data.Repositories
{
    public class InMemoryPlayerGamesRepository : IPlayerGameRepository
    {
        public Task<IEnumerable<PokemonGame>> GetPlayerGamesAsync(string playerId)
        {
            if (string.IsNullOrEmpty(playerId))
                throw new ArgumentNullException(nameof(playerId));

            return Task.FromResult(new List<PokemonGame>
            {
                new PokemonGame
                {
                    Name = "Pokémon Rouge",
                    Generation = 1,
                    Description = "Pokémon Rouge fait partie de la première génération de jeux Pokémon sortie en 1996 au Japon.",
                    ImageUrl = "https://www.pokepedia.fr/images/thumb/8/8b/Pok%C3%A9mon_Rouge_Recto.png/604px-Pok%C3%A9mon_Rouge_Recto.png?20180629110042"
                },
                new PokemonGame
                {
                    Name = "Pokémon Bleu",
                    Generation = 1,
                    Description = "Pokémon Bleu fait partie de la première génération de jeux Pokémon sortie en 1996 au Japon.",
                    ImageUrl = "https://www.pokepedia.fr/images/thumb/0/05/Pok%C3%A9mon_Bleu_Recto.png/604px-Pok%C3%A9mon_Bleu_Recto.png?20180629112656"
                },
                new PokemonGame
                {
                    Name = "Pokémon Jaune",
                    Generation = 1,
                    Description = "Pokémon Jaune fait partie de la première génération de jeux Pokémon sortie en 1998 au Japon.",
                    ImageUrl = "https://www.pokepedia.fr/images/thumb/b/b6/Pok%C3%A9mon_Jaune_Recto.png/608px-Pok%C3%A9mon_Jaune_Recto.png?20090217223151"
                }, 
                new PokemonGame
                {
                    Name = "Pokémon Or",
                    Generation = 2,
                    Description = "Pokémon Or fait partie de la deuxième génération de jeux Pokémon sortie en 1999 au Japon.",
                    ImageUrl = "https://www.pokepedia.fr/images/7/72/Jaquette_Pok%C3%A9mon_Or.png?20210707122240"
                },
                new PokemonGame
                {
                    Name = "Pokémon Argent",
                    Generation = 2,
                    Description = "Pokémon Argent fait partie de la deuxième génération de jeux Pokémon sortie en 1999 au Japon.",
                    ImageUrl = "https://www.pokepedia.fr/images/8/80/Jaquette_Pok%C3%A9mon_Argent.png?20210707122524"
                }
            }.AsEnumerable());
        }
    }
}
