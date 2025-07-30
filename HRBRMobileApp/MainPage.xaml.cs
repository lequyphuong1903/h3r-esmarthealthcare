namespace HRBRMobileApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainPageModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
