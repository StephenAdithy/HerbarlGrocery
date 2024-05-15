using Grocery08.Model;
using MudBlazor;

namespace Grocery08.Pages
{
    public partial class Home
    {
        List<ProductsModel> Produts = new List<ProductsModel>
        {
        new ProductsModel{FrontImage="img/Nissy/6.png",BackImage="img/Nissy/1.jpg",Name="Apple",Price="300.00",OldPrice="500.00"},
        new ProductsModel{FrontImage="img/Nissy/6.png",BackImage="img/Nissy/1.jpg",Name="Ball",Price="300.00",OldPrice="500.00"},
        new ProductsModel{FrontImage="img/Nissy/6.png",BackImage="img/Nissy/1.jpg",Name="Cat",Price="300.00",OldPrice="500.00"},
        new ProductsModel{FrontImage="img/Nissy/6.png",BackImage="img/Nissy/1.jpg",Name="Doll",Price="300.00",OldPrice="500.00"},
        new ProductsModel{FrontImage="img/Nissy/6.png",BackImage="img/Nissy/1.jpg",Name="Elephant",Price="300.00",OldPrice="500.00"},
        new ProductsModel{FrontImage="img/Nissy/6.png",BackImage="img/Nissy/1.jpg",Name="Fish",Price="300.00",OldPrice="500.00"},
        new ProductsModel{FrontImage="img/Nissy/6.png",BackImage="img/Nissy/1.jpg",Name="Graphs",Price="300.00",OldPrice="500.00"},
    };

        bool open;
        string drawerWidth = "450px";
        public string SelectedOption { get; set; }
        public int Quantity { get; set; }
        public bool Selected { get; set; } = false;
        private void HandleIconClick()
        {
            Selected = !Selected;
        }
        private void IncreaseQuantity()
        {
            Quantity++;
        }

        private void DecreaseQuantity()
        {
            if (Quantity > 0)
            {
                Quantity--;
            }
        }
        void ToggleDrawer()
        {
            open = !open;
            drawerWidth = open ? "400px" : "0px";
        }
        private bool arrows = true;
        private bool enableSwipeGesture = true;
        private bool autocycle = true;
        private Transition transition = Transition.Slide;
    }
}
