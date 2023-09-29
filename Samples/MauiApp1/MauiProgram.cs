using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MauiApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCompatibility()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .ConfigureMauiHandlers(handlers =>
            {
#if ANDROID
                    handlers.AddCompatibilityRenderer(typeof(Lottie.Forms.AnimationView), typeof(Lottie.Forms.Platforms.Android.AnimationViewRenderer));
#endif
#if IOS
                handlers.AddCompatibilityRenderer(typeof(Lottie.Forms.AnimationView), typeof(Lottie.Forms.Platforms.Ios.AnimationViewRenderer));
#endif
            });

        return builder.Build();
    }
}

