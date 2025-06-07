namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public required string OwnerName { get; set; }
        public string? Gym { get; set; }
    }
}