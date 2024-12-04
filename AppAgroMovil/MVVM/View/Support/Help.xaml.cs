namespace AppAgroMovil.MVVM.View.Support;

public partial class Help : ContentPage
{
	public Help()
	{
		InitializeComponent();

	}

    private async void OnDocumentationTapped(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://www.facebook.com/UTRNGOFICIAL/?locale=es_LA");
        await Launcher.OpenAsync(uri);
    }

    private async void OnFAQTapped(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://docs.google.com/forms/d/e/1FAIpQLScnMJe80cQ8zw1r5eIOQgjd330whtoApxkXW44zjD9gi6kvTA/viewform");
        await Launcher.OpenAsync(uri);
    }

    private async void OnSupportTapped(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://utrng.edu.mx/");
        await Launcher.OpenAsync(uri);
    }
}