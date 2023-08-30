using UnityEngine;

public class PokemonSpawner : MonoBehaviour
{
    public PokemonScriptable pokemonTemplate;

    public void SpawnPokemon()
    {
        PokemonScriptable newPokemon = Instantiate(pokemonTemplate);
        // Do something with the new Pokemon instance
    }
}
