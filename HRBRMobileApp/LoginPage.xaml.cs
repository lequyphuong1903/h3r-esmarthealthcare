using System.Net.Http;
using System.Text;
using System.Text.Json;
namespace HRBRMobileApp;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}