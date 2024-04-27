using MudBlazor;

namespace Grocery08.Pages
{
    public partial class Home
    {
        bool open;
        string drawerWidth = "400px";
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
