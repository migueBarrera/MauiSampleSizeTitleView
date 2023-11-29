using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;

namespace SampleSizeTitleView
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

#if DEBUG
            builder.Logging.AddDebug();
#endif

            ToolbarHandler.Mapper.Add("FixHeight", (handler, _) =>
            {
                handler.PlatformView.IsOpen = true;
                handler.PlatformView.IsSticky = true;
                handler.PlatformView.OverflowButtonVisibility = Microsoft.UI.Xaml.Controls.CommandBarOverflowButtonVisibility.Collapsed;
            });

            return builder.Build();
        }
    }
}
