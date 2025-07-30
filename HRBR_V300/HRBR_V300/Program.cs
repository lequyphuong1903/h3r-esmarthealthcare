using System.Threading.Tasks;
using HRBR_V300.views;

namespace HRBR_V300
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();
            Application.Run(new Form1());
        }
    }
}