using CommunityToolkit.Mvvm.ComponentModel;
using Firebase.Auth;
using Firebase.Database;

namespace HRBRMobileApp
{
    public partial class MainPageModel : ObservableObject
    {
        private readonly FirebaseAuthClient _authClient;
        private readonly FirebaseClient _firebaseClient;
        private readonly Timer _timer;
        private IDisposable _subscription;
        [ObservableProperty]
        private string _hRValue;
        [ObservableProperty]
        private string _rRValue;
        [ObservableProperty]
        private string _t1Value;
        [ObservableProperty]
        private string _t2Value;

        public MainPageModel(FirebaseAuthClient authClient, FirebaseClient client)
        {
            _authClient = authClient;
            _firebaseClient = client;
            _timer = new Timer(async _ => await UpdateValuesAsync(), null, 0, 1000);
        }
        
        private async Task UpdateValuesAsync()
        {
            var data = await _firebaseClient
                .Child(_authClient.User.Uid)
                .OnceSingleAsync<RealtimeData>();

            if (data != null)
            {
                HRValue = data.HR;
                RRValue = data.BR;
                T1Value = data.Temp1;
                T2Value = data.Temp2;
            }
        }
    }
}
