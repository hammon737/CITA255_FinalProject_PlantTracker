using System.Collections.ObjectModel;

namespace CITA255_FinalProject_PlantTracker;

public partial class ListOfPlants : ContentPage
{
	public ListOfPlants()
	{
		InitializeComponent();

		BindingContext = this;
	}
}