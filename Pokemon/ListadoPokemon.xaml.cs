using Newtonsoft.Json;
using Pokemon.Models;
using Pokemon.Services;
using System.Diagnostics;

namespace Pokemon;

public partial class ListadoPokemon : ContentPage
{
	public List<PokemonInfo> list_pokemon;
	public ListadoPokemon()
	{
		
		InitializeComponent();
		LoadData();
	

    }

	public async void LoadData()
    {
        PokemonApis _poke_apis = new PokemonApis();
        list_pokemon = await _poke_apis.DevuelveListadoPokemones();
		Debug.WriteLine("ola");
		Debug.WriteLine(JsonConvert.SerializeObject(list_pokemon));

		listado_pokemones.ItemsSource =list_pokemon;
    }
	public void MuestraResumenPokemon(EventArgs eventArgs)
    {
		PokemonInfo poke_info = (PokemonInfo)e.SelectedItem; 
		Navigation.PushAsync(new ResumenPokemon());
    }

} 