using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Database;
using Microsoft.Extensions.Logging;
using OxyPlot.Maui.Skia;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace HRBRMobileApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.UseSkiaSharp();
            builder.UseOxyPlotSkia();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyAKQ5GhTPiUZydGuCUDX9n2mu3dMpvcKGA",
                AuthDomain = "hrbr-project.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            }));
            builder.Services.AddSingleton(new FirebaseClient("https://hrbr-project-default-rtdb.firebaseio.com/"));
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<LoginModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageModel>();
            return builder.Build();
        }
    }
}
