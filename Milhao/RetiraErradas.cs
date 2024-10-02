namespace Milhao;

public class RetiraErradas : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        switch (questao.respostacerta)
        {

            case 1:
                buttonResposta2.IsVisible = false;
                buttonResposta3.IsVisible = false;
                buttonResposta4.IsVisible = false;
                buttonResposta5.IsVisible = false;
                break;

            case 2:
                buttonResposta1.IsVisible = false;
                buttonResposta3.IsVisible = false;
                buttonResposta4.IsVisible = false;
                buttonResposta5.IsVisible = false;
                break;

            case 3:
                buttonResposta1.IsVisible = false;
                buttonResposta2.IsVisible = false;
                buttonResposta4.IsVisible = false;
                buttonResposta5.IsVisible = false;
                break;

            case 4:
                buttonResposta1.IsVisible = false;
                buttonResposta2.IsVisible = false;
                buttonResposta3.IsVisible = false;
                buttonResposta5.IsVisible = false;
                break;

            case 5:
                buttonResposta1.IsVisible = false;
                buttonResposta2.IsVisible = false;
                buttonResposta3.IsVisible = false;
                buttonResposta4.IsVisible = false;
                break;


        }
    }

}