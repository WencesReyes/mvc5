using System.Collections.Generic;

namespace mvc_project.Models.Pokemon
{
    public class PokemonResponse
    {
        public List<Pokemon> Results { get; set; } = new List<Pokemon>();
    }
}