using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace Lottie.Forms;

public static class AppBuilderExtensions
{
    public static MauiAppBuilder UseLottie(this MauiAppBuilder builder)
    {
        builder
            .UseMauiCompatibility()
            .ConfigureMauiHandlers(handlers =>
            {
#if ANDROID
                    handlers.AddCompatibilityRenderer(typeof(Lottie.Forms.AnimationView), typeof(Lottie.Forms.Platforms.Android.AnimationViewRenderer));
#endif
#if IOS
                handlers.AddCompatibilityRenderer(typeof(Lottie.Forms.AnimationView),
                    typeof(Lottie.Forms.Platforms.Ios.AnimationViewRenderer));
#endif
            });
        return builder;
    }
}
