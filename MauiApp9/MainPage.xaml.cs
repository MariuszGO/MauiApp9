using System.Collections.ObjectModel;

namespace MauiApp9
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Samochod> Samochod_Kolekcja { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Samochod_Kolekcja = new ObservableCollection<Samochod>
            {
                new Samochod
                {
                    Marka = "Samochód 1",
                    Model = "S1",
                    Opis = "To jest opis do samochodu1",
                    ImageUrl = "sam1.jpg"
                },
                new Samochod
                {
                    Marka = "Samochód 2",
                    Model = "S2",
                    Opis = "To jest opis do samochodu2",   
                    ImageUrl = "sam2.jpg"
                },
                   new Samochod
                {
                    Marka = "Samochód 1",
                    Model = "S1",
                    Opis = "To jest opis do samochodu1",
                    ImageUrl = "sam3.jpg"
                },
                new Samochod
                {
                    Marka = "Samochód 2",
                    Model = "S2",
                    Opis = "To jest opis do samochodu2",
                    ImageUrl = "sam4.jpg"
                },
                   new Samochod
                {
                    Marka = "Samochód 1",
                    Model = "S1",
                    Opis = "To jest opis do samochodu1",
                    ImageUrl = "sam5.jpg"
                },
                new Samochod
                {
                    Marka = "Samochód 2",
                    Model = "S2",
                    Opis = "To jest opis do samochodu2",
                    ImageUrl = "sam6.jpg"
                },

            };

            BindingContext = this;
        }
     
    }

    public class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Opis { get; set; }
        public string ImageUrl { get; set; }
    }
}
