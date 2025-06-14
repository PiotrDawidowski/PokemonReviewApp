﻿namespace PokemonReviewApp.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
