using Calculator.ViewModels;

namespace Calculator;

public partial class App : Application
{
	public App(IServiceProvider serviceProvider)
	{
		InitializeComponent();

        //MainPage = new AppShell();
        MainPage = new NavigationPage(new LoginUI(serviceProvider.GetService<LoginViewModel>()));


    }
}
