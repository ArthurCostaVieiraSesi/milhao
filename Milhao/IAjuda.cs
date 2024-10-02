namespace Milhao;

public abstract class IAjuda
{
    protected Button buttonResposta1;
    protected Button buttonResposta2;
    protected Button buttonResposta3;
    protected Button buttonResposta4;
    protected Button buttonResposta5;
    protected Frame frameAjuda;

    public void ConfiguraDesenho(Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        this.buttonResposta1 = buttonResposta1;
        this.buttonResposta2 = buttonResposta2;
        this.buttonResposta3 = buttonResposta3;
        this.buttonResposta4 = buttonResposta4;
        this.buttonResposta5 = buttonResposta5;
    }

    public void ConfiguraDesenho(Frame frameAjuda)
    {
        this.frameAjuda = frameAjuda;
    }

    public abstract void RealizaAjuda(Questao questao);

}