using System.Diagnostics;

namespace CITA255_FinalProject_PlantTracker;

public partial class PlantDetails : ContentPage
{
	int points = 2;
	public PlantDetails()
	{
		InitializeComponent();
        plantImage();
	}

	void plantImage()
	{
        if (points == 2)
        {
            Pic.Source = "cactihappy.png";
        }
        if (points == 1)
        {
            Pic.Source = "cactisad.png";
        }
        if (points == 0)
        {
            Pic.Source = "cactidead.png";
        }
    }

    private void Success(object sender, EventArgs e)
    {
		if (points < 2) 
		{ 
			points += 1; 
		}
		Points.Text = points.ToString();
        plantImage();
    }

    private void Loss(object sender, EventArgs e)
    {
		if (points > 0)
		{
			points -= 1;
		}
        Points.Text = points.ToString();
        plantImage();
    }
}