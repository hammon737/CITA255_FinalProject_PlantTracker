using System.Collections.ObjectModel;

namespace CITA255_FinalProject_PlantTracker;

public partial class ListOfPlants : ContentPage
{
	ObservableCollection<Plant> Plants { get; } = ListMaker.userInput;

    public ListOfPlants()
	{
		InitializeComponent();

        BindingContext = this;
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