using System.Threading.Tasks;
using Firebase.Auth;
using HRBR_V300.utils;

namespace HRBR_V300.views
{
    public partial class SplashScreen : Form
    {
        public bool IsAuthenticated { get; private set; } = false;
        FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAKQ5GhTPiUZydGuCUDX9n2mu3dMpvcKGA"));
        public SplashScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void UpdateLoadingStatus(string message)
        {
            lblLoading.Text = message;
            Application.DoEvents();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string user = emailTxt.Text;
            string pass = passTxt.Text;
            try
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(user, pass);
                IsAuthenticated = true;
                panel1.Visible = false;
                Auth.UID = auth.User.LocalId;
                await RunSplashSequenceAsync();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check email, password and internet again!");
            }
        }
        private async Task RunSplashSequenceAsync()
        {
            UpdateLoadingStatus("Loading configuration...");
            await Task.Delay(1000);
            UpdateLoadingStatus("Initializing database...");
            await Task.Delay(1000);
            UpdateLoadingStatus("Loading user interface...");
            await Task.Delay(1000);
            UpdateLoadingStatus("Finalizing setup...");
            await Task.Delay(1000);
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
