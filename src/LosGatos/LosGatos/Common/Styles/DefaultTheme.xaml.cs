using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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