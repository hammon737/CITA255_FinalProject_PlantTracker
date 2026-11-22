using System.Diagnostics;

namespace CITA255_FinalProject_PlantTracker;

[QueryProperty(nameof(Index), "index")]

public partial class PlantDetails : ContentPage
{
    int index;
	public int points = 2;
    public PlantDetails()
	    {
		    InitializeComponent();
            points = 2;
        }
    public string Index
    {
        set
        {
            index = int.Parse(value);

            TitleLabel.Text = Waterpage.names[index];
            TypeLabel.Text = Waterpage.Avatar[index];
            plantImage();
        }
    }

	void plantImage()
	{
        if(TypeLabel.Text == "Cacti")
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
        else if (TypeLabel.Text == "Flower")
        {
            if (points == 2)
            {
                Pic.Source = "flowerhappy.png";
            }
            if (points == 1)
            {
                Pic.Source = "flowersad.png";
            }
            if (points == 0)
            {
                Pic.Source = "flowerdead.png";
            }
        }
        else if (TypeLabel.Text == "Shrub")
        {
            if (points == 2)
            {
                Pic.Source = "shrubhappy.png";
            }
            if (points == 1)
            {
                Pic.Source = "shrubsad.png";
            }
            if (points == 0)
            {
                Pic.Source = "shrubdead.png";
            }
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