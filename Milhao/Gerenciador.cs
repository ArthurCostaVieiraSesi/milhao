namespace Milhao;

public class Gerenciador
{

    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao questaoCorrente;

    public Gerenciador (Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5, Image compImg)
    {
        CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg); 
    }

    public void ProximaPergunta()
    {
        var numRandomico = Random.Shared.Next(0, ListaQuestoes.Count -1);
        while(ListaQuestoesRespondidas.Contains(numRandomico))
        numRandomico = Random.Shared.Next(0,ListaQuestoes.Count -1);
        ListaQuestoesRespondidas.Add(numRandomico);
        questaoCorrente = ListaQuestoes[numRandomico];
        questaoCorrente.Desenhar();
    }

    public async void VerificarCorreto(int resposta)
    {
        if (questaoCorrente!.VerifiicarResposta(resposta))
        {
            await Task.Delay(1500);
            ProximaPergunta();
        }
    }

    void CriarQuestoes(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5, Image compImg)
    {
        var Q1 = new Questao();
        Q1.pergunta = "Qual o verdadeiro nome de Jinx?";
        Q1.resposta1 = "Jessica";
        Q1.resposta2 = "Michely";
        Q1.resposta3 = "Powder";
        Q1.resposta4 = "Paola";
        Q1.resposta5 = "Nenhum, sempre foi Jinx";
        Q1.imagem = "powder.jpg";
        Q1.respostacerta = 3;
        Q1.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);

        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.pergunta = "Janna pertence a qual região?";
        Q2.resposta1 = "Targon";
        Q2.resposta2 = "Zaun";
        Q2.resposta3 = "Vazio";
        Q2.resposta4 = "Ionia";
        Q2.resposta5 = "Shurima";
        Q2.imagem = "janna.jpg";
        Q2.respostacerta = 2;
        Q2.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);

        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.pergunta = "";
        Q3.resposta1 = "";
        Q3.resposta2 = "";
        Q3.resposta3 = "";
        Q3.resposta4 = "";
        Q3.resposta5 = "";
        Q2.imagem = "";
        Q3.respostacerta = 5;
        Q3.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);

        ListaQuestoes.Add(Q3);

    }

}