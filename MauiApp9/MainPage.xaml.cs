namespace MauiApp9
{
    public partial class MainPage : ContentPage
    {
        public List<FoodItem> Food { get; set; }

        public MainPage()
        {
            InitializeComponent(); 

            Food = new List<FoodItem>
            {
                new FoodItem { Name = "Pizza", Description = "Włoski klasyk z serem i sosem pomidorowym" },
                new FoodItem { Name = "Burger", Description = "Wołowina, bułka i dodatki" },
                new FoodItem { Name = "Sushi", Description = "Ryż i świeża ryba" },
                new FoodItem { Name = "Sałatka", Description = "Zdrowa mieszanka warzyw" }
            };

            BindingContext = this; 
        }
    }

    public class FoodItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
