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
                Points.Text = $"You're doing great! {Waterpage.names[index]} looks so happy! Keep up the good work!";
            }
            if (points == 1)
            {
                Pic.Source = "cactisad.png";
                Points.Text = $"Keep an eye on {Waterpage.names[index]}! They're looking a bit droopy.";
            }
            if (points == 0)
            {
                Pic.Source = "cactidead.png";
                Points.Text = $"Oh no! {Waterpage.names[index]} isn't looking so good. Make to water them tomorrow.";
            }
        }
        else if (TypeLabel.Text == "Flower")
        {
            if (points == 2)
            {
                Pic.Source = "flowerhappy.png";
                Points.Text = $"You're doing great! {Waterpage.names[index]} looks so happy! Keep up the good work!";
            }
            if (points == 1)
            {
                Pic.Source = "flowersad.png";
                Points.Text = $"Keep an eye on {Waterpage.names[index]}! They're looking a bit droopy.";
            }
            if (points == 0)
            {
                Pic.Source = "flowerdead.png";
                Points.Text = $"Oh no! {Waterpage.names[index]} isn't looking so good. Make to water them tomorrow.";
            }
        }
        else if (TypeLabel.Text == "Shrub")
        {
            if (points == 2)
            {
                Pic.Source = "shrubhappy.png";
                Points.Text = $"You're doing great! {Waterpage.names[index]} looks so happy! Keep up the good work!";
            }
            if (points == 1)
            {
                Pic.Source = "shrubsad.png";
                Points.Text = $"Keep an eye on {Waterpage.names[index]}! They're looking a bit droopy."; ;
            }
            if (points == 0)
            {
                Pic.Source = "shrubdead.png";
                Points.Text = $"Oh no! {Waterpage.names[index]} isn't looking so good. Make to water them tomorrow.";
            }
        }
    }

    private void Success(object sender, EventArgs e)
    {
		if (points < 2) 
		{ 
			points += 1; 
		}
        plantImage();


    }

    private void Loss(object sender, EventArgs e)
    {
		if (points > 0)
		{
			points -= 1;
		}
        plantImage();
    }
}