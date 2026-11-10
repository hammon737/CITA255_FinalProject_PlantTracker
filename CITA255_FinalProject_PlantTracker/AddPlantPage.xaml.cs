using CITA255_FinalProject_PlantTracker;
using System.Collections.ObjectModel;

namespace FinalProject_PlantTracker;

public partial class AddPlantPage : ContentPage
{
    public ObservableCollection<Plant> Plants { get; } = new ObservableCollection<Plant>();

    Plant[] pool =
    {

    };

    void OnAddClicked(object sender, EventArgs e)
    {
        Plants.Add(new Plant { PlantNames = PlantName.Text, PlantTypes = PlantType.Text, WateringTimes = WaterTime.Text });
    }
}