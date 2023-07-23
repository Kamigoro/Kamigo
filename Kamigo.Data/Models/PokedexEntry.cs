namespace Kamigo.Data.Models
{
    public class PokedexEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Type { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string[] Abilities { get; set; }
        public string SpriteLocalUrl { get; set; }
    }
}
