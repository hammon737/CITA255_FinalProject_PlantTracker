namespace CITA255_FinalProject_PlantTracker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AddPlant(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("AddingPlants");
        }
        private async void SeePlants(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ViewPlants");
        }


    }
}
