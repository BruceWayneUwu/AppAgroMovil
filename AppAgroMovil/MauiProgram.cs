using AppAgroMovil.Data;
using AppAgroMovil.MVVM.View.Data;
using AppAgroMovil.MVVM.ViewModels;
using Microsoft.Extensions.Logging;

namespace AppAgroMovil
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
                    fonts.AddFont("MaterialSymbolsOutlined-Regular", "MaterialIcons");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<DatabaseContext>();
            builder.Services.AddSingleton<ProductsViewModel>();
            builder.Services.AddSingleton<DataAnalysis>();


            return builder.Build();
        }
    }
}
