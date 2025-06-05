namespace AntambaJPrueba.Views;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void IrAJokesPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new JokesPage());

    }

    private void IrAAboutPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AboutPage());

    }
}