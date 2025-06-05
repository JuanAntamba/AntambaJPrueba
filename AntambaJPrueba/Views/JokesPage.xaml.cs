using AntambaJPrueba.Repositories;

namespace AntambaJPrueba.Views;

public partial class JokesPage : ContentPage
{
    private readonly JokeRepository _jokeRepository = new();

    public JokesPage()
    {
        InitializeComponent();
        CargarChiste();
    }

    private async void CargarChiste()
    {
        JokeLabel.Text = "El chiste se esta generando";
        try
        {
            var joke = await _jokeRepository.GetRandomJokeAsync();
            JokeLabel.Text = $"{joke.Setup}\n\n{joke.Punchline}";
        }
        catch
        {
            JokeLabel.Text = "Fall de generacion";
        }
    }

    private void GenerarChiste_Clicked(object sender, EventArgs e)
    {
        CargarChiste();
    }
}

