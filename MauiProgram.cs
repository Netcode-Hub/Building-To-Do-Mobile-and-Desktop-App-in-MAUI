using Maui.ToDoList.ViewModels;
using Microsoft.Extensions.Logging;

namespace Maui.ToDoList;

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
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainPageViewModel>();

        builder.Services.AddSingleton<DetailPage>();
        builder.Services.AddSingleton<DetailPageViewModel>();

		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

        return builder.Build();
	}
}
