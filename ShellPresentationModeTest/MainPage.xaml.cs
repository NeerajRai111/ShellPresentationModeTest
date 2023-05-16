namespace ShellPresentationModeTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync($"{nameof(NewModelPage)}");
	}
}

