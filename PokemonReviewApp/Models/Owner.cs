namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public required string OwnerName { get; set; }
        public string? Gym { get; set; }
        public required Country Country { get; set; }
    }
}