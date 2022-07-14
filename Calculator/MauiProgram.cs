using Calculator.RestServices;
using Calculator.Services;
using Calculator.Services.Abstractions;
using Calculator.ViewModels;
using RestEase.HttpClientFactory;

namespace Calculator;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UsePrismApp<App>(prism =>
			{
				prism.RegisterTypes(container =>
				{
					//Navigation
					container.RegisterForNavigation<LoginUI, LoginViewModel>();
                    container.RegisterForNavigation<Home, HomeViewModel>();

                    //Services
                    container.RegisterSingleton<IAuthService, AuthService>();


                })
				.OnAppStart(navigationService => navigationService.CreateBuilder().AddNavigationPage().AddSegment<LoginViewModel>().Navigate());
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        
        return builder.Build();
    }
}
