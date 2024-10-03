namespace Milhao;

public class Questao: IEquatable<Questao>
{

    public string pergunta;

    public string resposta1;

    public string resposta2;

    public string resposta3;

    public string resposta4;

    public string resposta5;

    public int respostacerta;

    public string imagem;

    public int nivel;

    Label labelPergunta;

    Button buttonResposta1;

    Button buttonResposta2;

    Button buttonResposta3;

    Button buttonResposta4;

    Button buttonResposta5;

    Image componenteImagem;

    public bool Equals(Questao q)
    {
        return this.nivel == q.nivel && this.pergunta == q.pergunta;
    }

    public void Desenhar()
    {
        labelPergunta.Text = pergunta;
        buttonResposta1.Text = resposta1;
        buttonResposta2.Text = resposta2;
        buttonResposta3.Text = resposta3;
        buttonResposta4.Text = resposta4;
        buttonResposta5.Text = resposta5;
        componenteImagem.Source = imagem;

        buttonResposta1.BackgroundColor = Color.FromRgba("#abee93");
        buttonResposta1.TextColor = Color.FromRgba("#2d938e");
        buttonResposta2.BackgroundColor = Color.FromRgba("#abee93");
        buttonResposta2.TextColor = Color.FromRgba("#2d938e");
        buttonResposta3.BackgroundColor = Color.FromRgba("#abee93");
        buttonResposta3.TextColor = Color.FromRgba("#2d938e");
        buttonResposta4.BackgroundColor = Color.FromRgba("#abee93");
        buttonResposta4.TextColor = Color.FromRgba("#2d938e");
        buttonResposta5.BackgroundColor = Color.FromRgba("#abee93");
        buttonResposta5.TextColor = Color.FromRgba("#2d938e");
        buttonResposta1.IsVisible = true;
        buttonResposta2.IsVisible = true;
        buttonResposta3.IsVisible = true;
        buttonResposta4.IsVisible = true;
        buttonResposta5.IsVisible = true;
        buttonResposta1.Text = buttonResposta1.Text;
        buttonResposta2.Text = buttonResposta2.Text;
        buttonResposta3.Text = buttonResposta3.Text;
        buttonResposta4.Text = buttonResposta4.Text;
        buttonResposta5.Text = buttonResposta5.Text;
    }

    private Button buttonEscolhido(int respostaescolhida)
    {
        if (respostaescolhida == 1)
            return buttonResposta1;
        else if (respostaescolhida == 2)
            return buttonResposta2;
        else if (respostaescolhida == 3)
            return buttonResposta3;
        else if (respostaescolhida == 4)
            return buttonResposta4;
        else if (respostaescolhida == 5)
            return buttonResposta5;
        else 
            return null;
    }

    public bool VerifiicarResposta(int respostaescolhida)
    {
        if (respostacerta == respostaescolhida)
        {
            var verificacao = buttonEscolhido(respostaescolhida);
            verificacao.BackgroundColor = Colors.Green;
            verificacao.TextColor = Colors.White;
            return true;
        }
        else
        {
            var verificacaoCorreto = buttonEscolhido(respostacerta);
            var verificacaoIncorreto = buttonEscolhido(respostaescolhida);
            verificacaoCorreto.BackgroundColor = Colors.Yellow;
            verificacaoCorreto.TextColor = Colors.Black;
            verificacaoIncorreto.BackgroundColor = Colors.Red;
            verificacaoIncorreto.TextColor = Colors.White;
            return false;
        }
    }
    
    public void ConfigurarEstruturaDesenho(Label pergunta, Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5, Image imagem)
    {
        labelPergunta = pergunta;
        buttonResposta1 = resposta1;
        buttonResposta2 = resposta2;
        buttonResposta3 = resposta3;
        buttonResposta4 = resposta4;
        buttonResposta5 = resposta5;
        componenteImagem = imagem;
    }

    public Questao()
    {
    }

    public Questao(Label pergunta, Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5, Image imagem)
    {
        labelPergunta = pergunta;
        buttonResposta1 = resposta1;
        buttonResposta2 = resposta2;
        buttonResposta3 = resposta3;
        buttonResposta4 = resposta4;
        buttonResposta5 = resposta5;
        componenteImagem = imagem;
    }

}