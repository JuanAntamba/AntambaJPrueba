namespace AntambaJPrueba.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private void RegresarAMainPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
