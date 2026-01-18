using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Windows.Input;



namespace KoloryMaui.ModelWidoku;


partial class KolorMW : ObservableObject
{
    public Model.Kolor model = Model.Ustawienia.Czytaj();

    #region Właściwości


    public double R
    {
        get => model.R;
        set
        {
            if (model.R != value)
            {
                model.R = value;
                OnPropertyChanged(nameof(R));
                OnPropertyChanged(nameof(SolidColeur));
            }
        }
    }
    public double G
    {
        get => model.G;
        set
        {
            if (model.G != value)
            {
                model.G = value;
                OnPropertyChanged(nameof(G));
                OnPropertyChanged(nameof(SolidColeur));
            }
        }
    }

    public double B


    {


        get => model.B;
        set
        {
            if (model.B != value)
            {
                model.B = value;
                OnPropertyChanged(nameof(B));
                OnPropertyChanged(nameof(SolidColeur));

            }
        }
    }

    // zmienia kolor rectangle na podstawie wartości RGB

    public SolidColorBrush SolidColeur
    {
        get
        {
            return new SolidColorBrush(model.Coleur);
        }
        set
        {
            PodajNaKoncole();


            {
                model.Coleur = value.Color;
            }
            OnPropertyChanged(nameof(SolidColeur));
            PodajNaKoncole();
        }
    }

    public void PodajNaKoncole()
    {
        Debug.WriteLine($"R: {R}, G: {G}, B: {B}, Coleur: {model.Coleur}");
    }
    #endregion




    private readonly IRelayCommand _drukCommand;
    private readonly IRelayCommand _zapiszCommand;

    public IRelayCommand DrukCommand
    {
        get => _drukCommand;
    }

    public IRelayCommand ZapiszCommand
    {
        get => _zapiszCommand;
    }





    public KolorMW()
    {
        this._drukCommand = new RelayCommand(Druk, CanDruk);

        this._zapiszCommand = new RelayCommand(Zapisz, CanZapisz);
    }


    private void Druk()
    {
        Debug.WriteLine("Naciśnięto przycisk Druk");

        this.R = 0;
        this.G = 255;
        this.B = 0;
    }


    private bool CanDruk()
    {

        return true;

    }


    public void Zapisz()

    {
        Debug.WriteLine("Naciśnięto przycisk Zapisz");
        Model.Ustawienia.Zapisz(model);
    }
    public bool CanZapisz()
    {
        return true;
    }
}

    
