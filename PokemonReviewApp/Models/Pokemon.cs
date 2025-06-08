namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public required string PokemonName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
/* TODO: later, make it so that pokemons have both their "type" and "race" and as well idk how to name it xdd
look up how I should do it, new type or enum or whatever
*/