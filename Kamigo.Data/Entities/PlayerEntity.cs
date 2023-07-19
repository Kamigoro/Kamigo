namespace Kamigo.Data.Entities
{
    public class PlayerEntity
    {
        public string Pk => "player";
        public string Id { get; set; }
        public HashSet<int> GamesOwnedIds { get; set; }
    }
}
