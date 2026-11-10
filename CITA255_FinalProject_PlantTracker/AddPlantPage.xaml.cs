using System.Collections.ObjectModel;

namespace CITA255_FinalProject_PlantTracker;

public partial class AddPlantPage : ContentPage
{
    
    public ObservableCollection<Plant> Plants { get; } = new ObservableCollection<Plant>();
    public AddPlantPage()
    {
        InitializeComponent();
    }
    Plant[] pool =
    {
    };

    

    void OnAddClicked(object sender, EventArgs e)
    {
        Plants.Add(new Plant { PlantNames = PlantName.Text, PlantTypes = PlantType.Text, WateringTimes = WaterTime.Text });
        resultLabel.Text = "Plant added";
    }
}