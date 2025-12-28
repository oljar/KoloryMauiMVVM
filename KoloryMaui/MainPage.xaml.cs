using KoloryMaui.Model;

namespace KoloryMaui;

public partial class MainPage : ContentPage
{
   

    public MainPage()
    {
        InitializeComponent();

    }

            private void ContentPage_Disappearing(object sender, EventArgs e)
    {
      

        Model.Kolor kolor = new Model.Kolor(sliderR.Value, sliderG.Value, sliderB.Value);
        Model.Ustawienia.Zapisz(kolor);
    }
}




