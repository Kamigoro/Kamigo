using Kamigo.Data.Enums;

namespace Kamigo.Data.Models
{
    public class PokemonGame
    {
        public int Id { get; set; }
        public int Generation { get; set; }
        public string Name { get; set; }
        public PokemonRegions Region { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ImageUrl { get; set; }
    }
}
