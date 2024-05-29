using Bumptech.Glide.Util;
using Pokemon.Models;
using Pokemon.Services;

namespace Pokemon;

public partial class ResumenPokemon : ContentPage
{

	CaracteristicasPokemon caracteristicas = new CaracteristicasPokemon();
	public ResumenPokemon(string url)
	{
		InitializeComponent();
		CargaPokemon(url);
	}

	public  async void CargaPokemon(string url)
    {	
		PokemonApis poke_services = new PokemonApis();
		caracteristicas = await poke_services.DevuelveCaracteristicasPokemon(url);
		ImagePokemon.Source = caracteristicas.Sprites.front_default;

		string habilidades = "";
		foreach (var ability in caracteristicas.Abilities)
        {

            habilidades += ability.ability.name + " º ";
        }

		Habilidades.Text = habilidades;

    }
}