using Metal;
using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Services
{
    public class PokemonApis
    {

        public HttpClient _httpClient;
        public PokemonApis()
        { 
            _httpClient = new HttpClient();
        }

        public async List<PokemonInfo> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/ability/?limit=20&offset=20";
            string json = await _httpClient.GetStringAsync(url); 

        }

}

