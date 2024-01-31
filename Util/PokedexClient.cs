using System.Text.Json;
using Pokedex.Models;

namespace Pokedex.Util
{
    public class PokedexClient
    {
        public HttpClient Client { get; set; }
        public PokedexClient(HttpClient client)
        {
            this.Client = client;
        }

        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Pokemon>(content);  
        }
    }
}

