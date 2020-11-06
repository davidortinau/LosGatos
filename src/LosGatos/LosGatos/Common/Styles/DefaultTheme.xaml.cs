using Xamarin.Forms;

[assembly: ExportFont("fa-solid-900.ttf", Alias = "FontAwesome")]
[assembly: ExportFont("ProductSans-Regular.ttf", Alias = "Product")]
[assembly: ExportFont("RobotoMono-Regular.ttf", Alias = "Roboto")]
[assembly: ExportFont("norwester.otf", Alias = "Norwester")]
namespace Common.Styles
{
    public partial class DefaultTheme : ResourceDictionary
    {
        public DefaultTheme()
        {
            InitializeComponent();
        }
    }
}