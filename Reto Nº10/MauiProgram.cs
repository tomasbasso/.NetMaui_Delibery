using Microsoft.Extensions.Logging;

namespace Reto_Nº10
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
                    fonts.AddFont("Lato-Black.ttf", "black");
                    fonts.AddFont("Lato-Bold.ttf", "bold");
                    fonts.AddFont("Lato-Italic.ttf", "italic");
                    fonts.AddFont("Lato-Regular.ttf", "regular");
                    fonts.AddFont("Fonts.otf", "AwesomeSolid");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
