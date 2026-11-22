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

		for (int i = 0; i < Waterpage.names.Count; i++)
		{
			rows.Add($"{Waterpage.names[i]}");
		}

		CountLabel.Text = rows.Count + " Plants";

    }

	

    private async void OnPlantSelected(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.Count ==0)
		{
			return;
		}


		string picked = e.CurrentSelection[0].ToString();

		PlantView.SelectedItem = null;

		int index = rows.IndexOf(picked);
        await Shell.Current.GoToAsync($"PlantDet?index={index+1}");
	}
}