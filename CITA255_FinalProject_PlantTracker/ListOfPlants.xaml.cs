using System.Collections.ObjectModel;

namespace CITA255_FinalProject_PlantTracker;

public partial class ListOfPlants : ContentPage
{
	public ObservableCollection<Plant> newPlants => ListMaker.userInput;

	List<string> rows = new List<string>();


    public ListOfPlants()
	{
		InitializeComponent();

        BindingContext = this;

		for (int i = 0; i < ListMaker.userInput.Count; i++)
		{
			rows.Add($"{ListMaker.userInput[i]}");
		}

		CountLabel.Text = rows.Count + " Plants";

    }

	
    private async void OnPlantSelected(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.Count == 0)
		{
			return;
		}

		if (e.CurrentSelection[0] is not Plant picked)
		{
			return;
		}

		PlantView.SelectedItem = null;

		

		int index = ListMaker.userInput.IndexOf(picked);
		if (index < 0)
		{
			return;
		}
        await Shell.Current.GoToAsync($"PlantDet?index={index}");
	}
}