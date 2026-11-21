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
            plantImage();
        }
    public string Index
    {
        set
        {
            index = int.Parse(value);

            Pic.Source = Waterpage.Avatar[index];
            TitleLabel.Text = Waterpage.names[index];
            plantImage();
        }
    }

	void plantImage()
	{
        if(Pic.Source.ToString() == "File: cactihappy.png" || Pic.Source.ToString() == "File: cactisad.png" || Pic.Source.ToString() == "File: cactidead.png")
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
        else if (Pic.Source.ToString() == "File: flowerhappy.png" || Pic.Source.ToString() == "File: flowersad.png" || Pic.Source.ToString() == "File: flowerdead.png")
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