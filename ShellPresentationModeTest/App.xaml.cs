namespace ShellPresentationModeTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();
        Routing.RegisterRoute(nameof(NewModelPage), typeof(NewModelPage));

    }
}
