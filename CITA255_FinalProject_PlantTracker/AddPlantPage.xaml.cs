using System.Collections.ObjectModel;

namespace CITA255_FinalProject_PlantTracker;

public partial class AddPlantPage : ContentPage
{
    
    public ObservableCollection<Plant> Plants { get; } = new ObservableCollection<Plant>();
    public AddPlantPage()
    {
        InitializeComponent();

        BindingContext = this;
    }
    Plant[] pool =
    {

    };

    int next = 0;

    public void OnAddClicked(object sender, EventArgs e)
    {
        string waterTime = WaterTime.Text;
        if (int.TryParse(waterTime, out int water))
        {
            
        }
        else
        {
            return;
        }
        Plants.Add(new Plant { PlantNames = PlantName.Text, PlantTypes = PlantType.Text, WateringTimes = water });

        next++;
        if (next >= pool.Length)
        {
            next = 0;
        }
        
        ListMaker.Names.Add(PlantName.Text);
        ListMaker.Types.Add(PlantType.Text);
        ListMaker.Water.Add(water);

        resultLabel.Text = "Plant added";
    }

    private async void OnPlantSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0)
        {
            return;
        }

        await Shell.Current.GoToAsync("PlantDet");
    }
}