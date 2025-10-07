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
                    Marka = "Ford",
                    Model = "Mustang",
                    Opis = "Ford Mustang Shelby GT500",
                    ImageUrl = "sam1.jpg"
                },
                new Samochod
                {
                    Marka = "Mercedes",
                    Model = "W123",
                    Opis = "Mercedes W123 2.4D",   
                    ImageUrl = "sam2.jpg"
                },
                   new Samochod
                {
                    Marka = "BMW",
                    Model = "X3",
                    Opis = "BMW X3 3.0D ",
                    ImageUrl = "sam3.jpg"
                },
                new Samochod
                {
                    Marka = "Mercedes",
                    Model = "W124",
                    Opis = "Mercedes",
                    ImageUrl = "sam4.jpg"
                },
                   new Samochod
                {
                    Marka = "Mercedes",
                    Model = "CLK",
                    Opis = "Tu będzie opis",
                    ImageUrl = "sam5.jpg"
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
