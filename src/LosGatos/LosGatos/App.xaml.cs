using LosGatos.Pages;
using Xamarin.Forms;

namespace LosGatos
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Brush_Experimental", "Shapes_Experimental" });

            InitializeComponent();

            MainPage = new NavigationPage( new MainPage() ){
                BarBackgroundColor = Color.Transparent
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
