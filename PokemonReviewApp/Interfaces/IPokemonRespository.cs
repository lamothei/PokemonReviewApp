using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRespository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(String name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);

    }
}
