using System.Collections.ObjectModel;

namespace CITA255_FinalProject_PlantTracker;

public partial class ListOfPlants : ContentPage
{
    public ListOfPlants()
	{
		InitializeComponent();

	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		Refresh();
    }

	void Refresh()
	{
		List<string> list = new List<string>();

		PlantView.ItemsSource = list;
	}

	private async void OnPlantSelected(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.Count ==0)
		{
			return;
		}

		await Shell.Current.GoToAsync("PlantDet");
	}
}