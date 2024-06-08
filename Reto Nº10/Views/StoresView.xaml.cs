using Reto_Nº10.Models;

namespace RETO_10.Views;

public partial class StoresView : ContentPage
{
    public List<Store> Stores { get; set; }
    public StoresView()
    {
        InitializeComponent();
        LoadData();
        BindingContext = this;
    }

    private void LoadData()
    {
        Stores = new List<Store>
        {
            new Store
            {
                Id = 1,
                Header = "comida1.png",
                Logo = "logo1.png",
                Name = "Amarella",
                DeliveryTime = "15-20 min",
                Minimum = 6500,
                ServiceFee = 1000,
                Rating = 5
            },
             new Store
            {
                Id = 1,
                Header = "blackcomida.png",
                Logo = "blacklogo.png",
                Name = "Black Bart",
                DeliveryTime = "30-40 min",
                Minimum = 3200,
                ServiceFee = 1000,
                Rating = 3.5
            },
              new Store
            {
                Id = 1,
                Header = "chaltencomida.png",
                Logo = "chaltenlogo.png",
                Name = "Amarella",
                DeliveryTime = "20-30 min",
                Minimum = 7500,
                ServiceFee = 1500,
                Rating = 4
            },
            new Store
            {
                Id = 2,
                Header = "comidamostaza.jpeg",
                Logo = "logomostaza.png",
                Name = "Mostaza",
                DeliveryTime = "20-30 min",
                Minimum = 4500,
                ServiceFee = 1000,
                Rating = 4.3
            }
        };
    }
}
