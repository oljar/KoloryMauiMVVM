using KoloryMaui.Model;
using KoloryMaui.ModelWidoku;

namespace KoloryMaui;

public partial class MainPage : ContentPage
{
   

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new KolorMW();


    }

}




