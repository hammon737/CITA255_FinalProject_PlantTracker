using System.Collections.ObjectModel;

namespace CITA255_FinalProject_PlantTracker;

public partial class AddPlantPage : ContentPage
{
    
    public ObservableCollection<Plant> Plants { get; } = new ObservableCollection<Plant>();
    public AddPlantPage()
    {
        InitializeComponent();
        addButton.IsEnabled = false;
        BindingContext = this;
    }
    public Plant[] pool =
    {

    };

    int next = 0;


    void CPlant(object sender, EventArgs e)
    {
        PAvatar.Text = "Cacti";
        addButton.IsEnabled = true;
        AvatarPic.Source = "cactihappy.png";
    }
    void FlPlant(object sender, EventArgs e)
    {
        PAvatar.Text = "Flower";
        addButton.IsEnabled = true;
        AvatarPic.Source = "flowerhappy.png";
    }
    void ShPlant(object sender, EventArgs e)
    {
        PAvatar.Text = "Shrub";
        addButton.IsEnabled = true;
        AvatarPic.Source = "shrubhappy.png";
    }


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
        Plants.Add(new Plant { PlantNames = PlantName.Text, 
            PlantTypes = PlantType.Text, 
            WateringTimes = water,
            PlantImage = PAvatar.Text});
        

        next++;
        if (next >= pool.Length)
        {
            next = 0;
        }

        ListMaker.userInput = Plants;
        
        Waterpage.Avatar.Add(PAvatar.Text);
        Waterpage.names.Add(PlantName.Text);

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