using consumir_web_api.Servicios;
using Microsoft.Extensions.Logging;

namespace consumir_web_api
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


            builder.Services.AddSingleton<IRickAndMortyService, RickAndMortyService>();
            builder.Services.AddTransient<MainPage>();

#if DEBUG

            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
