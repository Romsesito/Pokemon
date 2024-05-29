﻿
using Newtonsoft.Json;
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

        public async Task<List<PokemonInfo>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/ability/?limit=20&offset=20";
            string json = await _httpClient.GetStringAsync(url);

            ResourceList resourcelist_pokemon = JsonConvert.DeserializeObject<ResourceList>(json);
            return resourcelist_pokemon.results;
        }


        public async Task <CaracteristicasPokemon> DevuelveCaracteristicasPokemon(string url)
        {
            string json = await _httpClient.GetStringAsync( url);
            CaracteristicasPokemon caracteristicas = JsonConvert.DeserializeObject<CaracteristicasPokemon>(json);
            return caracteristicas;
        }



    }
}

