namespace Milhao;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;

	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelPergunta, labelPontuacao, labelNivel, buttonPlaca, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, Img);
	}

	void Clicked01(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(1);
	}

	void Clicked02(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(2);
	}

	void Clicked03(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(3);
	}

	void Clicked04(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(4);
	}

	void Clicked05(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(5);
	}

	void Placa(object sender, EventArgs e)
	{
		var a = new RetiraErradas();
		a.ConfiguraDesenho(buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
		a.RealizaAjuda(gerenciador.questaoCorrente);
		buttonPlaca.IsVisible = false;
	}

}

