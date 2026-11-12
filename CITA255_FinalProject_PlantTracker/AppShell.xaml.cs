namespace CITA255_FinalProject_PlantTracker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("AddingPlants", typeof(AddPlantPage));
            Routing.RegisterRoute("ViewPlants", typeof(ListOfPlants));
            Routing.RegisterRoute("PlantDet", typeof(PlantDetails));
        }
    }
}
