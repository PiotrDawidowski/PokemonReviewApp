namespace PokemonReviewApp.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public required string CountryName { get; set; }
        public ICollection<Owner>? Owners { get; set; }
    }
}