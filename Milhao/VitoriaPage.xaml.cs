namespace Milhao;

public partial class VitoriaPage : ContentPage
{

	public VitoriaPage()
	{
		InitializeComponent();
	}

    void Sorocaba(object sender, EventArgs args)
    {
        Application.Current.MainPage = new InicioPage();
    }

}