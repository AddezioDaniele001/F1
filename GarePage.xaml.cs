using F1App.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace F1App;

public partial class GarePage : ContentPage
{
	private string GareUrl = "https://ergast.com/api/f1/2001.json";
    private readonly HttpClient _httpClient = new HttpClient();

    public ObservableCollection<Gare> GareList = new();

    public GarePage()
	{
		InitializeComponent();
		_httpClient=new HttpClient();
		GareCollectionView.ItemsSource = GareList;

	}



    protected override async void OnAppearing()
    {
        base.OnAppearing();
        LoadData();
    }

    public async void LoadData()
	{
		var GareResponse=await _httpClient.GetFromJsonAsync<ApiREsponseGare>(GareUrl);

		foreach (var Gare in GareList)
		{
			GareList.Add(Gare);
		}
	}
}