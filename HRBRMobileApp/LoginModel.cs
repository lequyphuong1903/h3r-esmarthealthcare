using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;

namespace HRBRMobileApp
{
    public partial class LoginModel : ObservableObject
    {
        private readonly FirebaseAuthClient _authClient;
        [ObservableProperty]
        private string _email;
        [ObservableProperty]
        private string _password;
        public LoginModel(FirebaseAuthClient authClient)
        {
            _authClient = authClient;
        }
        [RelayCommand]
        private async Task SignIn()
        {
            await _authClient.SignInWithEmailAndPasswordAsync(Email, Password);
            await Shell.Current.GoToAsync("MainPage");
        }
    }
}
