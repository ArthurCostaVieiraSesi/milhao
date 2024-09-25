namespace Milhao;

public partial class CreditosPage : ContentPage
{

	public CreditosPage()
	{
		InitializeComponent();
	}

    void Creditu(object sender, EventArgs args)
    {
        Application.Current.MainPage = new InicioPage();
    }

}