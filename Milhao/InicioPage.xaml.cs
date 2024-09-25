namespace Milhao;

public partial class InicioPage : ContentPage
{

	public InicioPage()
	{
		InitializeComponent();
	}

    void Comecar(object sender, EventArgs args)
    {
        Application.Current.MainPage = new MainPage();
    }

    void Credite(object sender, EventArgs args)
    {
        Application.Current.MainPage = new CreditosPage();
    }

}