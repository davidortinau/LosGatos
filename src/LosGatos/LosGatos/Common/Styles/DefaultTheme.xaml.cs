using Xamarin.Forms;

[assembly: ExportFont("fa-solid-900.ttf", Alias = "FontAwesome")]
[assembly: ExportFont("DMSans-Bold.ttf", Alias = "DMSansBold")]
[assembly: ExportFont("DMSans-Regular.ttf", Alias = "DMSans")]
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