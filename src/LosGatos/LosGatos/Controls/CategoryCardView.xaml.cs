using System;
using Xamarin.Forms;


namespace LosGatos.Controls
{
    public partial class CategoryCardView : Grid
    {
        public static readonly BindableProperty BackgroundGradientProperty = BindableProperty.Create(nameof(BackgroundGradient), typeof(LinearGradientBrush), typeof(CategoryCardView), default(LinearGradientBrush));
        public LinearGradientBrush BackgroundGradient
        {
            get => (LinearGradientBrush)GetValue(BackgroundGradientProperty);
            set => SetValue(BackgroundGradientProperty, value);
        }

        public static readonly BindableProperty ProductImageProperty = BindableProperty.Create(nameof(ProductImage), typeof(ImageSource), typeof(CategoryCardView), default(ImageSource));
        public ImageSource ProductImage
        {
            get => (ImageSource)GetValue(ProductImageProperty);
            set => SetValue(ProductImageProperty, value);
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(CategoryCardView), default(string));
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        
        public CategoryCardView()
        {
            BindingContext = this;

            InitializeComponent();
        }
    }
}