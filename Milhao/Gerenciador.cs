namespace Milhao;

public class Gerenciador
{

    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao questaoCorrente;
    Label labelPontuacao;
    Label labelNivel;

    public Gerenciador(Label labelPergunta, Label labelPont, Label labelNivel, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5, Image compImg)
    {
        CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        labelPontuacao = labelPont;
        this.labelNivel = labelNivel;
    }
    

    public void ProximaPergunta()
    {
        var numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
        while (ListaQuestoesRespondidas.Contains(numRandomico))
            numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
        ListaQuestoesRespondidas.Add(numRandomico);
        questaoCorrente = ListaQuestoes[numRandomico];
        questaoCorrente.Desenhar();
    }

    void AdicionaPontuacao(int michelly)
    {
        if (michelly == 1)
            Pontuacao = 1000;
        else if (michelly == 2)
            Pontuacao = 2000;
        else if (michelly == 3)
            Pontuacao = 5000;
        else if (michelly == 4)
            Pontuacao = 10000;
        else if (michelly == 5)
            Pontuacao = 20000;
        else if (michelly == 6)
            Pontuacao = 50000;
        else if (michelly == 7)
            Pontuacao = 100000;
        else if (michelly == 8)
            Pontuacao = 200000;
        else if (michelly == 9)
            Pontuacao = 500000;
        else
            Pontuacao = 1000000;
    }

    public async void VerificarCorreto(int resposta)
    {
        if (questaoCorrente!.VerifiicarResposta(resposta))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            ProximaPergunta();
            labelPontuacao.Text = "Pontuação: R$" + Pontuacao.ToString();
            labelNivel.Text = "Nivel:" + NivelAtual.ToString();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Burro", "Você errou, é facil falar mal de você, dificil é acreditar que você consegue! Aqui, é só regresso! ;)", "Ok");
            Inicializar();
        }
    }

    public int Pontuacao { get; private set; }

    int NivelAtual = 0;

    void Inicializar()
    {
        labelPontuacao.Text = "Pontuação: R$" + Pontuacao.ToString();
        labelNivel.Text = "Nivel:" + NivelAtual.ToString();
        Pontuacao = 0;
        NivelAtual = 0;
        ProximaPergunta();
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
        Q1.imagem = "logo.png";
        Q1.nivel = 1;
        Q1.respostacerta = 3;
        Q1.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);

        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.pergunta = "Qual campeão(a) é conhecido(a) como a 'Fera Indomável'?";
        Q2.resposta1 = "Rengar";
        Q2.resposta2 = "Nidalee";
        Q2.resposta3 = "Volibear";
        Q2.resposta4 = "Warwick";
        Q2.resposta5 = "Renekton";
        Q2.imagem = "logo.png";
        Q2.nivel = 1;
        Q2.respostacerta = 4;
        Q2.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.pergunta = "Qual o verdadeiro nome de Zed?";
        Q3.resposta1 = "Jhin";
        Q3.resposta2 = "Shen";
        Q3.resposta3 = "Khada Jhin";
        Q3.resposta4 = "Govos";
        Q3.resposta5 = "Nenhum, ele sempre foi Zed";
        Q3.imagem = "logo.png";
        Q3.nivel = 1;
        Q3.respostacerta = 3;
        Q3.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q3);

        var Q4 = new Questao();
        Q4.pergunta = "Qual desses campeões não é um suporte?";
        Q4.resposta1 = "Soraka";
        Q4.resposta2 = "Leona";
        Q4.resposta3 = "Veigar";
        Q4.resposta4 = "Nami";
        Q4.resposta5 = "Thresh";
        Q4.imagem = "logo.png";
        Q4.nivel = 1;
        Q4.respostacerta = 3;
        Q4.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.pergunta = "Qual campeão é considerado o 'Rei Destruído'?";
        Q5.resposta1 = "Viego";
        Q5.resposta2 = "Darius";
        Q5.resposta3 = "Mordekaiser";
        Q5.resposta4 = "Aatrox";
        Q5.resposta5 = "Sion";
        Q5.imagem = "logo.png";
        Q5.nivel = 1;
        Q5.respostacerta = 1;
        Q5.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.pergunta = "Qual campeão é um Yordle cientista?";
        Q6.resposta1 = "Teemo";
        Q6.resposta2 = "Rumble";
        Q6.resposta3 = "Corki";
        Q6.resposta4 = "Heimerdinger";
        Q6.resposta5 = "Veigar";
        Q6.imagem = "logo.png";
        Q6.nivel = 1;
        Q6.respostacerta = 4;
        Q6.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.pergunta = "Qual desses campeões tem a habilidade chamada 'Chuva de Disparos'?";
        Q7.resposta1 = "Lucian";
        Q7.resposta2 = "Miss Fortune";
        Q7.resposta3 = "Jinx";
        Q7.resposta4 = "Caitlyn";
        Q7.resposta5 = "Ashe";
        Q7.imagem = "logo.png";
        Q7.nivel = 1;
        Q7.respostacerta = 2;
        Q7.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q7);

        var Q8 = new Questao();
        Q8.pergunta = "Qual é o verdadeiro nome de Miss Fortune?";
        Q8.resposta1 = "Sarah Fortune";
        Q8.resposta2 = "Elise la Renegada";
        Q8.resposta3 = "Samira";
        Q8.resposta4 = "Riven";
        Q8.resposta5 = "Sylas";
        Q8.imagem = "logo.png";
        Q8.nivel = 1;
        Q8.respostacerta = 1;
        Q8.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q8);

        var Q9 = new Questao();
        Q9.pergunta = "Qual é o campeão conhecido como 'A Sombra das Lâminas'?";
        Q9.resposta1 = "Talon";
        Q9.resposta2 = "Zed";
        Q9.resposta3 = "Shen";
        Q9.resposta4 = "Yasuo";
        Q9.resposta5 = "Akali";
        Q9.imagem = "logo.png";
        Q9.nivel = 1;
        Q9.respostacerta = 1;
        Q9.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.pergunta = "Qual desses campeões tem uma habilidade chamada 'Lâminas Vorazes'?";
        Q10.resposta1 = "Irelia";
        Q10.resposta2 = "Riven";
        Q10.resposta3 = "Fiora";
        Q10.resposta4 = "Yasuo";
        Q10.resposta5 = "Aatrox";
        Q10.imagem = "logo.png";
        Q10.nivel = 1;
        Q10.respostacerta = 1;
        Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q10);

        var Q11 = new Questao();
        Q11.pergunta = "Qual é o nome da irmã de Kayn?";
        Q11.resposta1 = "Shen";
        Q11.resposta2 = "Rhaast";
        Q11.resposta3 = "Xayah";
        Q11.resposta4 = "Ele não tem irmã";
        Q11.resposta5 = "Akali";
        Q11.imagem = "logo.png";
        Q11.nivel = 2;
        Q11.respostacerta = 4;
        Q11.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q11);

        var Q12 = new Questao();
        Q12.pergunta = "Qual desses campeões é uma Sentinela da Luz?";
        Q12.resposta1 = "Lucian";
        Q12.resposta2 = "Thresh";
        Q12.resposta3 = "Pyke";
        Q12.resposta4 = "Viego";
        Q12.resposta5 = "Sylas";
        Q12.imagem = "logo.png";
        Q12.nivel = 2;
        Q12.respostacerta = 1;
        Q12.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q12);

        var Q13 = new Questao();
        Q13.pergunta = "Qual desses campeões é famoso por usar um arco e flecha?";
        Q13.resposta1 = "Ashe";
        Q13.resposta2 = "Caitlyn";
        Q13.resposta3 = "Braum";
        Q13.resposta4 = "Jinx";
        Q13.resposta5 = "Senna";
        Q13.imagem = "logo.png";
        Q13.nivel = 2;
        Q13.respostacerta = 1;
        Q13.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.pergunta = "Qual desses campeões é um dragão?";
        Q14.resposta1 = "Mordekaiser";
        Q14.resposta2 = "Aurelion Sol";
        Q14.resposta3 = "Galio";
        Q14.resposta4 = "Braum";
        Q14.resposta5 = "Nasus";
        Q14.imagem = "logo.png";
        Q14.nivel = 2;
        Q14.respostacerta = 2;
        Q14.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.pergunta = "Qual desses campeões pertence ao grupo K/DA?";
        Q15.resposta1 = "Ahri";
        Q15.resposta2 = "Evelynn";
        Q15.resposta3 = "Akali";
        Q15.resposta4 = "Kai'Sa";
        Q15.resposta5 = "Todas as anteriores";
        Q15.imagem = "logo.png";
        Q15.nivel = 2;
        Q15.respostacerta = 5;
        Q15.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q15);

        var Q16 = new Questao();
        Q16.pergunta = "Qual campeão é o 'Patrono da Destruição'?";
        Q16.resposta1 = "Sion";
        Q16.resposta2 = "Darius";
        Q16.resposta3 = "Aatrox";
        Q16.resposta4 = "Ornn";
        Q16.resposta5 = "Nasus";
        Q16.imagem = "logo.png";
        Q16.nivel = 2;
        Q16.respostacerta = 3;
        Q16.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.pergunta = "Qual desses campeões é conhecido como o 'Rei dos Trolls'?";
        Q17.resposta1 = "Trundle";
        Q17.resposta2 = "Ornn";
        Q17.resposta3 = "Braum";
        Q17.resposta4 = "Shyvana";
        Q17.resposta5 = "Gnar";
        Q17.imagem = "logo.png";
        Q17.nivel = 2;
        Q17.respostacerta = 1;
        Q17.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q17);

        var Q18 = new Questao();
        Q18.pergunta = "Qual campeão foi criado por Singed?";
        Q18.resposta1 = "Warwick";
        Q18.resposta2 = "Urgot";
        Q18.resposta3 = "Dr. Mundo";
        Q18.resposta4 = "Zac";
        Q18.resposta5 = "Sion";
        Q18.imagem = "logo.png";
        Q18.nivel = 2;
        Q18.respostacerta = 1;
        Q18.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q18);

        var Q19 = new Questao();
        Q19.pergunta = "Qual desses campeões é da tribo Freljordiana?";
        Q19.resposta1 = "Ashe";
        Q19.resposta2 = "Sejuani";
        Q19.resposta3 = "Lissandra";
        Q19.resposta4 = "Tryndamere";
        Q19.resposta5 = "Todas as anteriores";
        Q19.imagem = "logo.png";
        Q19.nivel = 2;
        Q19.respostacerta = 5;
        Q19.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q19);

        var Q20 = new Questao();
        Q20.pergunta = "Qual campeão é conhecido como 'O Azote de Noxus'?";
        Q20.resposta1 = "Darius";
        Q20.resposta2 = "Draven";
        Q20.resposta3 = "Swain";
        Q20.resposta4 = "Talon";
        Q20.resposta5 = "Riven";
        Q20.imagem = "logo.png";
        Q20.nivel = 2;
        Q20.respostacerta = 1;
        Q20.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q20);

        var Q21 = new Questao();
        Q21.pergunta = "Qual campeão é o 'Terror das Profundezas'?";
        Q21.resposta1 = "Nautilus";
        Q21.resposta2 = "Pyke";
        Q21.resposta3 = "Fizz";
        Q21.resposta4 = "Tahm Kench";
        Q21.resposta5 = "Nami";
        Q21.imagem = "logo.png";
        Q21.respostacerta = 1;
        Q21.nivel = 3;
        Q21.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q21);

        var Q22 = new Questao();
        Q22.pergunta = "Qual é a habilidade suprema de Yasuo?";
        Q22.resposta1 = "Tempestade de Aço";
        Q22.resposta2 = "Corte do Vento";
        Q22.resposta3 = "Parede de Vento";
        Q22.resposta4 = "Último Suspiro";
        Q22.resposta5 = "Lâmina do Errante";
        Q22.imagem = "logo.png";
        Q22.respostacerta = 4;
        Q22.nivel = 3;
        Q22.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q22);

        var Q23 = new Questao();
        Q23.pergunta = "Qual campeão é conhecido como o 'Olho do Crepúsculo'?";
        Q23.resposta1 = "Zilean";
        Q23.resposta2 = "Kennen";
        Q23.resposta3 = "Shen";
        Q23.resposta4 = "Jax";
        Q23.resposta5 = "Akali";
        Q23.imagem = "logo.png";
        Q23.respostacerta = 3;
        Q23.nivel = 3;
        Q23.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q23);

        var Q24 = new Questao();
        Q24.pergunta = "Qual desses campeões tem a habilidade 'Chuva de Canivetes'?";
        Q24.resposta1 = "Swain";
        Q24.resposta2 = "Katarina";
        Q24.resposta3 = "Rengar";
        Q24.resposta4 = "Akali";
        Q24.resposta5 = "Talon";
        Q24.imagem = "logo.png";
        Q24.respostacerta = 2;
        Q24.nivel = 3;
        Q24.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q24);

        var Q25 = new Questao();
        Q25.pergunta = "Qual campeão é conhecido como o 'Devorador de Mundos'?";
        Q25.resposta1 = "Cho'Gath";
        Q25.resposta2 = "Aatrox";
        Q25.resposta3 = "Nasus";
        Q25.resposta4 = "Malzahar";
        Q25.resposta5 = "Kog'Maw";
        Q25.imagem = "logo.png";
        Q25.respostacerta = 1;
        Q25.nivel = 3;
        Q25.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q25);

        var Q26 = new Questao();
        Q26.pergunta = "Qual desses campeões usa como arma uma corrente com uma foice?";
        Q26.resposta1 = "Thresh";
        Q26.resposta2 = "Urgot";
        Q26.resposta3 = "Darius";
        Q26.resposta4 = "Kayn";
        Q26.resposta5 = "Nautilus";
        Q26.imagem = "logo.png";
        Q26.respostacerta = 1;
        Q26.nivel = 3;
        Q26.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q26);

        var Q27 = new Questao();
        Q27.pergunta = "Qual desses campeões é um assassino especialista em dano explosivo?";
        Q27.resposta1 = "Talon";
        Q27.resposta2 = "Viktor";
        Q27.resposta3 = "Garen";
        Q27.resposta4 = "Yorick";
        Q27.resposta5 = "Leona";
        Q27.imagem = "logo.png";
        Q27.respostacerta = 1;
        Q27.nivel = 3;
        Q27.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q27);

        var Q28 = new Questao();
        Q28.pergunta = "Qual campeão tem a habilidade de se curar ao devorar almas?";
        Q28.resposta1 = "Swain";
        Q28.resposta2 = "Thresh";
        Q28.resposta3 = "Sylas";
        Q28.resposta4 = "Aatrox";
        Q28.resposta5 = "Vladimir";
        Q28.imagem = "logo.png";
        Q28.respostacerta = 1;
        Q28.nivel = 3;
        Q28.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q28);

        var Q29 = new Questao();
        Q29.pergunta = "Qual desses campeões tem uma habilidade chamada 'Estandarte de Demacia'?";
        Q29.resposta1 = "Garen";
        Q29.resposta2 = "Jarvan IV";
        Q29.resposta3 = "Xin Zhao";
        Q29.resposta4 = "Lux";
        Q29.resposta5 = "Sion";
        Q29.imagem = "logo.png";
        Q29.respostacerta = 2;
        Q29.nivel = 3;
        Q29.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q29);

        var Q30 = new Questao();
        Q30.pergunta = "Qual campeão é o 'Mestre das Sombras'?";
        Q30.resposta1 = "Shen";
        Q30.resposta2 = "Akali";
        Q30.resposta3 = "Zed";
        Q30.resposta4 = "Talon";
        Q30.resposta5 = "Kayn";
        Q30.imagem = "logo.png";
        Q30.respostacerta = 3;
        Q30.nivel = 3;
        Q30.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q30);

        var Q31 = new Questao();
        Q31.pergunta = "Qual campeão é o 'Protetor de Ionia'?";
        Q31.resposta1 = "Irelia";
        Q31.resposta2 = "Lee Sin";
        Q31.resposta3 = "Shen";
        Q31.resposta4 = "Karma";
        Q31.resposta5 = "Master Yi";
        Q31.imagem = "logo.png";
        Q31.respostacerta = 3;
        Q31.nivel = 4;
        Q31.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q31);

        var Q32 = new Questao();
        Q32.pergunta = "Qual habilidade de Ashe dá visão do mapa?";
        Q32.resposta1 = "Foco do Caçador";
        Q32.resposta2 = "Tiro Congelado";
        Q32.resposta3 = "Flecha de Cristal Encantada";
        Q32.resposta4 = "Olhar do Falcão";
        Q32.resposta5 = "Disparo Concentrado";
        Q32.imagem = "logo.png";
        Q32.respostacerta = 4;
        Q32.nivel = 4;
        Q32.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q32);

        var Q33 = new Questao();
        Q33.pergunta = "Qual desses campeões é conhecido como 'O Juggernaut' de Piltover?";
        Q33.resposta1 = "Vi";
        Q33.resposta2 = "Caitlyn";
        Q33.resposta3 = "Jinx";
        Q33.resposta4 = "Ezreal";
        Q33.resposta5 = "Jayce";
        Q33.imagem = "logo.png";
        Q33.respostacerta = 1;
        Q33.nivel = 4;
        Q33.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q33);

        var Q34 = new Questao();
        Q34.pergunta = "Qual campeão é conhecido como 'O Grande Pedregulho'?";
        Q34.resposta1 = "Malphite";
        Q34.resposta2 = "Braum";
        Q34.resposta3 = "Sion";
        Q34.resposta4 = "Ornn";
        Q34.resposta5 = "Galio";
        Q34.imagem = "logo.png";
        Q34.respostacerta = 1;
        Q34.nivel = 4;
        Q34.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q34);

        var Q35 = new Questao();
        Q35.pergunta = "Qual campeão é conhecido como 'O Terremoto Andante'?";
        Q35.resposta1 = "Malphite";
        Q35.resposta2 = "Rammus";
        Q35.resposta3 = "Sion";
        Q35.resposta4 = "Ornn";
        Q35.resposta5 = "Galio";
        Q35.imagem = "logo.png";
        Q35.respostacerta = 5;
        Q35.nivel = 4;
        Q35.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q35);

        var Q36 = new Questao();
        Q36.pergunta = "Qual é a habilidade passiva de Teemo?";
        Q36.resposta1 = "Tiro Tóxico";
        Q36.resposta2 = "Tecnicas de Guerrilha";
        Q36.resposta3 = "Camuflagem";
        Q36.resposta4 = "Furtividade Mortal";
        Q36.resposta5 = "Investida Cega";
        Q36.imagem = "logo.png";
        Q36.respostacerta = 2;
        Q36.nivel = 4;
        Q36.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q36);

        var Q37 = new Questao();
        Q37.pergunta = "Qual desses campeões foi amaldiçoado por uma arma mágica?";
        Q37.resposta1 = "Viego";
        Q37.resposta2 = "Aphelios";
        Q37.resposta3 = "Jhin";
        Q37.resposta4 = "Senna";
        Q37.resposta5 = "Rengar";
        Q37.imagem = "logo.png";
        Q37.respostacerta = 4;
        Q37.nivel = 4;
        Q37.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q37);

        var Q38 = new Questao();
        Q38.pergunta = "Qual campeão tem a habilidade suprema 'Devorar'?";
        Q38.resposta1 = "Cho'Gath";
        Q38.resposta2 = "Tahm Kench";
        Q38.resposta3 = "Kha'Zix";
        Q38.resposta4 = "Zac";
        Q38.resposta5 = "Rek'Sai";
        Q38.imagem = "logo.png";
        Q38.respostacerta = 2;
        Q38.nivel = 4;
        Q38.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q38);

        var Q39 = new Questao();
        Q39.pergunta = "Qual desses campeões pode se transformar em outro jogador?";
        Q39.resposta1 = "Sylas";
        Q39.resposta2 = "Ekko";
        Q39.resposta3 = "Neeko";
        Q39.resposta4 = "Shaco";
        Q39.resposta5 = "LeBlanc";
        Q39.imagem = "logo.png";
        Q39.respostacerta = 3;
        Q39.nivel = 4;
        Q39.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q39);

        var Q40 = new Questao();
        Q40.pergunta = "Qual desses campeões é um demônio?";
        Q40.resposta1 = "Swain";
        Q40.resposta2 = "Tahm Kench";
        Q40.resposta3 = "Aatrox";
        Q40.resposta4 = "Evelynn";
        Q40.resposta5 = "Evelynn e Tahm Kench";
        Q40.imagem = "logo.png";
        Q40.respostacerta = 5;
        Q40.nivel = 4;
        Q40.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q40);

        var Q41 = new Questao();
        Q41.pergunta = "Qual campeão é conhecido como 'A Mãe da Guerra'?";
        Q41.resposta1 = "Irelia";
        Q41.resposta2 = "Sejuani";
        Q41.resposta3 = "Riven";
        Q41.resposta4 = "Leona";
        Q41.resposta5 = "Karma";
        Q41.imagem = "logo.png";
        Q41.respostacerta = 2;
        Q41.nivel = 5;
        Q41.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q41);

        var Q42 = new Questao();
        Q42.pergunta = "Qual desses campeões pode mudar de forma (metamorfose)?";
        Q42.resposta1 = "Gnar";
        Q42.resposta2 = "Elise";
        Q42.resposta3 = "Nidalee";
        Q42.resposta4 = "Jayce";
        Q42.resposta5 = "Todos os anteriores";
        Q42.imagem = "logo.png";
        Q42.respostacerta = 5;
        Q42.nivel = 5;
        Q42.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q42);

        var Q43 = new Questao();
        Q43.pergunta = "Qual é a cidade natal de Ekko?";
        Q43.resposta1 = "Zaun";
        Q43.resposta2 = "Piltover";
        Q43.resposta3 = "Demacia";
        Q43.resposta4 = "Freljord";
        Q43.resposta5 = "Ionia";
        Q43.imagem = "logo.png";
        Q43.respostacerta = 1;
        Q43.nivel = 5;
        Q43.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q43);

        var Q44 = new Questao();
        Q44.pergunta = "Qual campeão pode invocar um clone para confundir os inimigos?";
        Q44.resposta1 = "Shaco";
        Q44.resposta2 = "LeBlanc";
        Q44.resposta3 = "Neeko";
        Q44.resposta4 = "Wukong";
        Q44.resposta5 = "Todos os anteriores";
        Q44.imagem = "logo.png";
        Q44.respostacerta = 5;
        Q44.nivel = 5;
        Q44.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q44);

        var Q45 = new Questao();
        Q45.pergunta = "Qual campeão é o 'Rei Arruinado'?";
        Q45.resposta1 = "Viego";
        Q45.resposta2 = "Tryndamere";
        Q45.resposta3 = "Nasus";
        Q45.resposta4 = "Renekton";
        Q45.resposta5 = "Mordekaiser";
        Q45.imagem = "logo.png";
        Q45.respostacerta = 1;
        Q45.nivel = 5;
        Q45.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q45);

        var Q46 = new Questao();
        Q46.pergunta = "Qual desses campeões é um colosso de pedra?";
        Q46.resposta1 = "Malphite";
        Q46.resposta2 = "Galio";
        Q46.resposta3 = "Sion";
        Q46.resposta4 = "Ornn";
        Q46.resposta5 = "Rammus";
        Q46.imagem = "logo.png";
        Q46.respostacerta = 2;
        Q46.nivel = 5;
        Q46.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q46);

        var Q47 = new Questao();
        Q47.pergunta = "Qual campeão tem a habilidade suprema 'Crescimento Virente'?";
        Q47.resposta1 = "Zyra";
        Q47.resposta2 = "Maokai";
        Q47.resposta3 = "Ivern";
        Q47.resposta4 = "Yuumi";
        Q47.resposta5 = "Rengar";
        Q47.imagem = "logo.png";
        Q47.respostacerta = 3;
        Q47.nivel = 5;
        Q47.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q47);

        var Q48 = new Questao();
        Q48.pergunta = "Qual é a habilidade passiva de Kayn ao alternar suas formas?";
        Q48.resposta1 = "Foice Arcana";
        Q48.resposta2 = "Caminho das Sombras";
        Q48.resposta3 = "Rastro de Sangue";
        Q48.resposta4 = "Reaper de Sombra";
        Q48.resposta5 = "Domínio das Sombras";
        Q48.imagem = "logo.png";
        Q48.respostacerta = 1;
        Q48.nivel = 5;
        Q48.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q48);

        var Q49 = new Questao();
        Q49.pergunta = "Qual campeão é um caçador de dragões?";
        Q49.resposta1 = "Shyvana";
        Q49.resposta2 = "Pantheon";
        Q49.resposta3 = "Vayne";
        Q49.resposta4 = "Aatrox";
        Q49.resposta5 = "Rengar";
        Q49.imagem = "logo.png";
        Q49.respostacerta = 3;
        Q49.nivel = 5;
        Q49.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q49);

        var Q50 = new Questao();
        Q50.pergunta = "Qual é a cidade natal de Twisted Fate?";
        Q50.resposta1 = "Aguas de Sentina";
        Q50.resposta2 = "Zaun";
        Q50.resposta3 = "Ionia";
        Q50.resposta4 = "Piltover";
        Q50.resposta5 = "Demacia";
        Q50.imagem = "logo.png";
        Q50.respostacerta = 1;
        Q50.nivel = 5;
        Q50.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q50);

        var Q51 = new Questao();
        Q51.pergunta = "Qual campeão é conhecido como 'O Defensor de Demacia'?";
        Q51.resposta1 = "Garen";
        Q51.resposta2 = "Jarvan IV";
        Q51.resposta3 = "Lux";
        Q51.resposta4 = "Fiora";
        Q51.resposta5 = "Sylas";
        Q51.imagem = "logo.png";
        Q51.respostacerta = 1;
        Q51.nivel = 6;
        Q51.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q51);

        var Q52 = new Questao();
        Q52.pergunta = "Qual campeão tem a habilidade suprema 'Destinizar'?";
        Q52.resposta1 = "Twisted Fate";
        Q52.resposta2 = "Kassadin";
        Q52.resposta3 = "Ryze";
        Q52.resposta4 = "Ekko";
        Q52.resposta5 = "Zilean";
        Q52.imagem = "logo.png";
        Q52.respostacerta = 1;
        Q52.nivel = 6;
        Q52.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q52);

        var Q53 = new Questao();
        Q53.pergunta = "Qual desses campeões usa uma espada como arma principal?";
        Q53.resposta1 = "Yasuo";
        Q53.resposta2 = "Riven";
        Q53.resposta3 = "Fiora";
        Q53.resposta4 = "Aatrox";
        Q53.resposta5 = "Todos os anteriores";
        Q53.imagem = "logo.png";
        Q53.respostacerta = 5;
        Q53.nivel = 6;
        Q53.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q53);

        var Q54 = new Questao();
        Q54.pergunta = "Qual campeão é a representação física de uma tormenta?";
        Q54.resposta1 = "Ziggs";
        Q54.resposta2 = "Janna";
        Q54.resposta3 = "Kennen";
        Q54.resposta4 = "Zed";
        Q54.resposta5 = "Volibear";
        Q54.imagem = "logo.png";
        Q54.respostacerta = 5;
        Q54.nivel = 6;
        Q54.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q54);

        var Q55 = new Questao();
        Q55.pergunta = "Qual é a habilidade suprema de Karthus?";
        Q55.resposta1 = "Paredão da Dor";
        Q55.resposta2 = "Definhamento";
        Q55.resposta3 = "Requiém";
        Q55.resposta4 = "Desafio Ardente";
        Q55.resposta5 = "Lamento";
        Q55.imagem = "logo.png";
        Q55.respostacerta = 3;
        Q55.nivel = 6;
        Q55.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q55);

        var Q56 = new Questao();
        Q56.pergunta = "Qual campeão pode criar uma 'Força Incontrolável'?";
        Q56.resposta1 = "Malphite";
        Q56.resposta2 = "Orianna";
        Q56.resposta3 = "Rammus";
        Q56.resposta4 = "Vi";
        Q56.resposta5 = "Sion";
        Q56.imagem = "logo.png";
        Q56.respostacerta = 5;
        Q56.nivel = 6;
        Q56.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q56);

        var Q57 = new Questao();
        Q57.pergunta = "Qual desses campeões é conhecido por ser um caçador das selvas?";
        Q57.resposta1 = "Warwick";
        Q57.resposta2 = "Rengar";
        Q57.resposta3 = "Kindred";
        Q57.resposta4 = "Graves";
        Q57.resposta5 = "Todos os anteriores";
        Q57.imagem = "logo.png";
        Q57.respostacerta = 2;
        Q57.nivel = 6;
        Q57.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q57);

        var Q58 = new Questao();
        Q58.pergunta = "Qual campeão pode voar com um dragão?";
        Q58.resposta1 = "Shyvana";
        Q58.resposta2 = "Aurelion Sol";
        Q58.resposta3 = "Swain";
        Q58.resposta4 = "Pantheon";
        Q58.resposta5 = "Kled";
        Q58.imagem = "logo.png";
        Q58.respostacerta = 2;
        Q58.nivel = 6;
        Q58.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q58);

        var Q59 = new Questao();
        Q59.pergunta = "Qual campeão pode capturar almas inimigas como parte de sua passiva?";
        Q59.resposta1 = "Thresh";
        Q59.resposta2 = "Kalista";
        Q59.resposta3 = "Mordekaiser";
        Q59.resposta4 = "Pyke";
        Q59.resposta5 = "Viego";
        Q59.imagem = "logo.png";
        Q59.respostacerta = 1;
        Q59.nivel = 6;
        Q59.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q59);

        var Q60 = new Questao();
        Q60.pergunta = "Qual campeão é conhecido como o 'Aruaceiro de Aguas de Sentina'?";
        Q60.resposta1 = "Gangplank";
        Q60.resposta2 = "Twisted Fate";
        Q60.resposta3 = "Pyke";
        Q60.resposta4 = "Miss Fortune";
        Q60.resposta5 = "Illaoi";
        Q60.imagem = "logo.png";
        Q60.respostacerta = 1;
        Q60.nivel = 6;
        Q60.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q60);

        var Q61 = new Questao();
        Q61.pergunta = "Qual campeão tem a habilidade passiva 'Anime-se!'?";
        Q61.resposta1 = "Jinx";
        Q61.resposta2 = "Hecarim";
        Q61.resposta3 = "Zilean";
        Q61.resposta4 = "Rammus";
        Q61.resposta5 = "Draven";
        Q61.imagem = "logo.png";
        Q61.respostacerta = 1;
        Q61.nivel = 7;
        Q61.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q61);

        var Q62 = new Questao();
        Q62.pergunta = "Qual desses campeões tem uma habilidade chamada 'Parede de Vento'?";
        Q62.resposta1 = "Janna";
        Q62.resposta2 = "Yasuo";
        Q62.resposta3 = "Rakan";
        Q62.resposta4 = "Ornn";
        Q62.resposta5 = "Braum";
        Q62.imagem = "logo.png";
        Q62.respostacerta = 2;
        Q62.nivel = 7;
        Q62.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q62);

        var Q63 = new Questao();
        Q63.pergunta = "Qual desses campeões é conhecido por carregar uma lâmina mágica?";
        Q63.resposta1 = "Riven";
        Q63.resposta2 = "Kayle";
        Q63.resposta3 = "Aatrox";
        Q63.resposta4 = "Tryndamere";
        Q63.resposta5 = "Fiora";
        Q63.imagem = "logo.png";
        Q63.respostacerta = 1;
        Q63.nivel = 7;
        Q63.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q63);

        var Q64 = new Questao();
        Q64.pergunta = "Qual desses campeões é conhecido por sua habilidade de regeneração rápida?";
        Q64.resposta1 = "Dr. Mundo";
        Q64.resposta2 = "Warwick";
        Q64.resposta3 = "Briar";
        Q64.resposta4 = "Garen";
        Q64.resposta5 = "Todos os anteriores";
        Q64.imagem = "logo.png";
        Q64.respostacerta = 5;
        Q64.nivel = 7;
        Q64.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q64);

        var Q65 = new Questao();
        Q65.pergunta = "Qual campeão possui a passiva 'Ataque Duplo'?";
        Q65.resposta1 = "Lee Sin";
        Q65.resposta2 = "Riven";
        Q65.resposta3 = "Xin Zhao";
        Q65.resposta4 = "Master Yi";
        Q65.resposta5 = "Jax";
        Q65.imagem = "logo.png";
        Q65.respostacerta = 4;
        Q65.nivel = 7;
        Q65.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q65);

        var Q66 = new Questao();
        Q66.pergunta = "Qual campeão é conhecido como o 'Caçador Orgulhoso'?";
        Q66.resposta1 = "Rengar";
        Q66.resposta2 = "Kha'Zix";
        Q66.resposta3 = "Graves";
        Q66.resposta4 = "Twitch";
        Q66.resposta5 = "Nocturne";
        Q66.imagem = "logo.png";
        Q66.respostacerta = 1;
        Q66.nivel = 7;
        Q66.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q66);

        var Q67 = new Questao();
        Q67.pergunta = "Qual desses campeões utiliza uma âncora como arma?";
        Q67.resposta1 = "Gangplank";
        Q67.resposta2 = "Thresh";
        Q67.resposta3 = "Nautilus";
        Q67.resposta4 = "Pyke";
        Q67.resposta5 = "Maokai";
        Q67.imagem = "logo.png";
        Q67.respostacerta = 3;
        Q67.nivel = 7;
        Q67.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q67);

        var Q68 = new Questao();
        Q68.pergunta = "Qual campeão tem a habilidade 'Espinho de odio'?";
        Q68.resposta1 = "Zed";
        Q68.resposta2 = "Evelynn";
        Q68.resposta3 = "Akali";
        Q68.resposta4 = "Vex";
        Q68.resposta5 = "Morgana";
        Q68.imagem = "logo.png";
        Q68.respostacerta = 2;
        Q68.nivel = 7;
        Q68.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q68);

        var Q69 = new Questao();
        Q69.pergunta = "Qual desses campeões é considerado um 'Anjo Caído'?";
        Q69.resposta1 = "Kayle";
        Q69.resposta2 = "Morgana";
        Q69.resposta3 = "Soraka";
        Q69.resposta4 = "Aatrox";
        Q69.resposta5 = "Zyra";
        Q69.imagem = "logo.png";
        Q69.respostacerta = 2;
        Q69.nivel = 7;
        Q69.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q69);

        var Q70 = new Questao();
        Q70.pergunta = "Qual é a cidade natal de Ekko?";
        Q70.resposta1 = "Piltover";
        Q70.resposta2 = "Zaun";
        Q70.resposta3 = "Ionia";
        Q70.resposta4 = "Noxus";
        Q70.resposta5 = "Demacia";
        Q70.imagem = "logo.png";
        Q70.respostacerta = 2;
        Q70.nivel = 7;
        Q70.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q70);

        var Q71 = new Questao();
        Q71.pergunta = "Qual campeão é conhecido como 'O Exterminador de Tanques'?";
        Q71.resposta1 = "Kog'Maw";
        Q71.resposta2 = "Vayne";
        Q71.resposta3 = "Camille";
        Q71.resposta4 = "Illaoi";
        Q71.resposta5 = "Tahm Kench";
        Q71.imagem = "logo.png";
        Q71.respostacerta = 2;
        Q71.nivel = 8;
        Q71.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q71);

        var Q72 = new Questao();
        Q72.pergunta = "Qual campeão utiliza o veneno como principal ferramenta de combate?";
        Q72.resposta1 = "Singed";
        Q72.resposta2 = "Twitch";
        Q72.resposta3 = "Cassiopeia";
        Q72.resposta4 = "Teemo";
        Q72.resposta5 = "Todos os anteriores";
        Q72.imagem = "logo.png";
        Q72.respostacerta = 5;
        Q72.nivel = 8;
        Q72.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q72);

        var Q73 = new Questao();
        Q73.pergunta = "Qual desses campeões NÃO pertence ao grupo 'As Sentinelas da Luz'?";
        Q73.resposta1 = "Viego";
        Q73.resposta2 = "Senna";
        Q73.resposta3 = "Lucian";
        Q73.resposta4 = "Graves";
        Q73.resposta5 = "Vayne";
        Q73.imagem = "logo.png";
        Q73.respostacerta = 1;
        Q73.nivel = 8;
        Q73.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q73);

        var Q74 = new Questao();
        Q74.pergunta = "Qual campeão é conhecido por sua habilidade de se transformar em um dragão?";
        Q74.resposta1 = "Shyvana";
        Q74.resposta2 = "Aurelion Sol";
        Q74.resposta3 = "Swain";
        Q74.resposta4 = "Mordekaiser";
        Q74.resposta5 = "Pantheon";
        Q74.imagem = "logo.png";
        Q74.respostacerta = 1;
        Q74.nivel = 8;
        Q74.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q74);

        var Q75 = new Questao();
        Q75.pergunta = "Qual campeão tem a habilidade 'Surto Elétrico'?";
        Q75.resposta1 = "Zed";
        Q75.resposta2 = "Kennen";
        Q75.resposta3 = "Janna";
        Q75.resposta4 = "Yasuo";
        Q75.resposta5 = "Volibear";
        Q75.imagem = "logo.png";
        Q75.respostacerta = 2;
        Q75.nivel = 8;
        Q75.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q75);

        var Q76 = new Questao();
        Q76.pergunta = "Qual campeão é conhecido como 'O Monstro de Zaun'?";
        Q76.resposta1 = "Singed";
        Q76.resposta2 = "Twitch";
        Q76.resposta3 = "Warwick";
        Q76.resposta4 = "Dr. Mundo";
        Q76.resposta5 = "Urgot";
        Q76.imagem = "logo.png";
        Q76.respostacerta = 3;
        Q76.nivel = 8;
        Q76.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q76);

        var Q77 = new Questao();
        Q77.pergunta = "Qual desses campeões é famoso por sua habilidade de controlar a mente de inimigos?";
        Q77.resposta1 = "Malzahar";
        Q77.resposta2 = "Lissandra";
        Q77.resposta3 = "Syndra";
        Q77.resposta4 = "LeBlanc";
        Q77.resposta5 = "Nenhum";
        Q77.imagem = "logo.png";
        Q77.respostacerta = 4;
        Q77.nivel = 8;
        Q77.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q77);

        var Q78 = new Questao();
        Q78.pergunta = "Qual campeão utiliza cogumelos como armadilha?";
        Q78.resposta1 = "Teemo";
        Q78.resposta2 = "Twitch";
        Q78.resposta3 = "Ziggs";
        Q78.resposta4 = "Jhin";
        Q78.resposta5 = "Heimerdinger";
        Q78.imagem = "logo.png";
        Q78.respostacerta = 1;
        Q78.nivel = 8;
        Q78.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q78);

        var Q79 = new Questao();
        Q79.pergunta = "Qual campeão fica imortal sob sua 'Forma Suprema'?";
        Q79.resposta1 = "Warwick";
        Q79.resposta2 = "Kindred";
        Q79.resposta3 = "Lillia";
        Q79.resposta4 = "Nasus";
        Q79.resposta5 = "Volibear";
        Q79.imagem = "logo.png";
        Q79.respostacerta = 2;
        Q79.nivel = 9;
        Q79.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q79);

        var Q80 = new Questao();
        Q80.pergunta = "Qual campeão é conhecido como o 'Deus do Trovão'?";
        Q80.resposta1 = "Zilean";
        Q80.resposta2 = "Volibear";
        Q80.resposta3 = "Ornn";
        Q80.resposta4 = "Pantheon";
        Q80.resposta5 = "Aatrox";
        Q80.imagem = "logo.png";
        Q80.respostacerta = 2;
        Q80.nivel = 9;
        Q80.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q80);

        var Q81 = new Questao();
        Q81.pergunta = "Qual campeão utiliza portais para se teletransportar e mover aliados?";
        Q81.resposta1 = "Bardo";
        Q81.resposta2 = "Thresh";
        Q81.resposta3 = "Rakan";
        Q81.resposta4 = "Yuumi";
        Q81.resposta5 = "Zoe";
        Q81.imagem = "logo.png";
        Q81.respostacerta = 1;
        Q81.nivel = 9;
        Q81.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q81);

        var Q82 = new Questao();
        Q82.pergunta = "Qual campeão possui a habilidade de 'Correntes Etéreas'?";
        Q82.resposta1 = "LeBlanc";
        Q82.resposta2 = "Morgana";
        Q82.resposta3 = "Lissandra";
        Q82.resposta4 = "Lux";
        Q82.resposta5 = "Karma";
        Q82.imagem = "logo.png";
        Q82.respostacerta = 1;
        Q82.nivel = 9;
        Q82.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q82);

        var Q83 = new Questao();
        Q83.pergunta = "Qual campeão tentou ressucitar sua esposa falecida?";
        Q83.resposta1 = "Viego";
        Q83.resposta2 = "Lucian";
        Q83.resposta3 = "Thresh";
        Q83.resposta4 = "Hecarim";
        Q83.resposta5 = "Kalista";
        Q83.imagem = "logo.png";
        Q83.respostacerta = 1;
        Q83.nivel = 9;
        Q83.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q83);

        var Q84 = new Questao();
        Q84.pergunta = "Qual campeão é famoso por sua habilidade de se clonar e enganar os inimigos?";
        Q84.resposta1 = "LeBlanc";
        Q84.resposta2 = "Shaco";
        Q84.resposta3 = "Neeko";
        Q84.resposta4 = "Wukong";
        Q84.resposta5 = "Todos os anteriores";
        Q84.imagem = "logo.png";
        Q84.respostacerta = 5;
        Q84.nivel = 9;
        Q84.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q84);

        var Q85 = new Questao();
        Q85.pergunta = "Qual campeão tem a habilidade de prender inimigos em uma prisão de energia?";
        Q85.resposta1 = "Lux";
        Q85.resposta2 = "Morgana";
        Q85.resposta3 = "Veigar";
        Q85.resposta4 = "Xerath";
        Q85.resposta5 = "Syndra";
        Q85.imagem = "logo.png";
        Q85.respostacerta = 3;
        Q85.nivel = 9;
        Q85.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q85);

        var Q86 = new Questao();
        Q86.pergunta = "Qual campeão é um andarilho espiritual de Ionia?";
        Q86.resposta1 = "Karma";
        Q86.resposta2 = "Yone";
        Q86.resposta3 = "Shen";
        Q86.resposta4 = "Soraka";
        Q86.resposta5 = "Master Yi";
        Q86.imagem = "logo.png";
        Q86.respostacerta = 2;
        Q86.nivel = 10;
        Q86.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q86);

        var Q87 = new Questao();
        Q87.pergunta = "Qual campeão é conhecido como o 'Coração de Freljord'?";
        Q87.resposta1 = "Ashe";
        Q87.resposta2 = "Braum";
        Q87.resposta3 = "Sejuani";
        Q87.resposta4 = "Tryndamere";
        Q87.resposta5 = "Lissandra";
        Q87.imagem = "logo.png";
        Q87.respostacerta = 2;
        Q87.nivel = 10;
        Q87.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q87);

        var Q88 = new Questao();
        Q88.pergunta = "Qual desses campeões pode criar portais para outras dimensões?";
        Q88.resposta1 = "Zoe";
        Q88.resposta2 = "Tahm Kench";
        Q88.resposta3 = "Bard";
        Q88.resposta4 = "Ekko";
        Q88.resposta5 = "Lissandra";
        Q88.imagem = "logo.png";
        Q88.respostacerta = 1;
        Q88.nivel = 10;
        Q88.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q88);

        var Q89 = new Questao();
        Q89.pergunta = "Qual campeão é famoso por suas lâminas dançantes?";
        Q89.resposta1 = "Talon";
        Q89.resposta2 = "Irelia";
        Q89.resposta3 = "Riven";
        Q89.resposta4 = "Yasuo";
        Q89.resposta5 = "Fiora";
        Q89.imagem = "logo.png";
        Q89.respostacerta = 2;
        Q89.nivel = 10;
        Q89.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q89);

        var Q90 = new Questao();
        Q90.pergunta = "Qual campeão é o irmão de Darius?";
        Q90.resposta1 = "Draven";
        Q90.resposta2 = "Swain";
        Q90.resposta3 = "Jarvan IV";
        Q90.resposta4 = "Garen";
        Q90.resposta5 = "Kled";
        Q90.imagem = "logo.png";
        Q90.respostacerta = 1;
        Q90.nivel = 10;
        Q90.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q90);

        var Q91 = new Questao();
        Q91.pergunta = "Qual campeão tem um poro mordomo?";
        Q91.resposta1 = "Jayce";
        Q91.resposta2 = "Caitlyn";
        Q91.resposta3 = "Jinx";
        Q91.resposta4 = "Viktor";
        Q91.resposta5 = "Heimerdinger";
        Q91.imagem = "logo.png";
        Q91.respostacerta = 5;
        Q91.nivel = 10;
        Q91.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q91);

        var Q92 = new Questao();
        Q92.pergunta = "Qual campeão é conhecido como 'A Vingança Reencarnada'?";
        Q92.resposta1 = "Kalista";
        Q92.resposta2 = "Mordekaiser";
        Q92.resposta3 = "Sion";
        Q92.resposta4 = "Hecarim";
        Q92.resposta5 = "Karthus";
        Q92.imagem = "logo.png";
        Q92.respostacerta = 1;
        Q92.nivel = 10;
        Q92.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q92);

        var Q93 = new Questao();
        Q93.pergunta = "Qual campeão é especialista em atravessar paredes?";
        Q93.resposta1 = "Kayn";
        Q93.resposta2 = "Talon";
        Q93.resposta3 = "Zed";
        Q93.resposta4 = "Ekko";
        Q93.resposta5 = "Kassadin";
        Q93.imagem = "logo.png";
        Q93.respostacerta = 1;
        Q93.nivel = 10;
        Q93.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q93);

        var Q94 = new Questao();
        Q94.pergunta = "Qual campeão tem habilidades relacionadas com corvos?";
        Q94.resposta1 = "Swain";
        Q94.resposta2 = "Fiddlesticks";
        Q94.resposta3 = "Nocturne";
        Q94.resposta4 = "Shaco";
        Q94.resposta5 = "Zyra";
        Q94.imagem = "logo.png";
        Q94.respostacerta = 1;
        Q94.nivel = 10;
        Q94.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q94);

        var Q95 = new Questao();
        Q95.pergunta = "Qual campeão é conhecido por ser uma arma viva?";
        Q95.resposta1 = "Rengar";
        Q95.resposta2 = "Jhin";
        Q95.resposta3 = "Kha'Zix";
        Q95.resposta4 = "Jinx";
        Q95.resposta5 = "Kai'Sa";
        Q95.imagem = "logo.png";
        Q95.respostacerta = 5;
        Q95.nivel = 10;
        Q95.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q95);

        var Q96 = new Questao();
        Q96.pergunta = "Qual campeão tem uma habilidade chamada 'Constelação Cadente'?";
        Q96.resposta1 = "Pantheon";
        Q96.resposta2 = "Riven";
        Q96.resposta3 = "Aatrox";
        Q96.resposta4 = "Sion";
        Q96.resposta5 = "Jarvan IV";
        Q96.imagem = "logo.png";
        Q96.respostacerta = 1;
        Q96.nivel = 10;
        Q96.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q96);

        var Q97 = new Questao();
        Q97.pergunta = "Qual campeão é um vastaya de 9 caudas?";
        Q97.resposta1 = "Rakan";
        Q97.resposta2 = "Xayah";
        Q97.resposta3 = "Yasuo";
        Q97.resposta4 = "Kayn";
        Q97.resposta5 = "Ahri";
        Q97.imagem = "logo.png";
        Q97.respostacerta = 5;
        Q97.nivel = 10;
        Q97.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q97);

        var Q98 = new Questao();
        Q98.pergunta = "Qual campeão tem uma habilidade de regeneração extremamente rápida após sofrer ferimentos graves?";
        Q98.resposta1 = "Garen";
        Q98.resposta2 = "Warwick";
        Q98.resposta3 = "Tryndamere";
        Q98.resposta4 = "Vladimir";
        Q98.resposta5 = "Mundo";
        Q98.imagem = "logo.png";
        Q98.respostacerta = 3;
        Q98.nivel = 10;
        Q98.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q98);

        var Q99 = new Questao();
        Q99.pergunta = "Qual campeão é conhecido como o 'Terror das Areias'?";
        Q99.resposta1 = "Sivir";
        Q99.resposta2 = "Nasus";
        Q99.resposta3 = "Renekton";
        Q99.resposta4 = "Xerath";
        Q99.resposta5 = "Azir";
        Q99.imagem = "logo.png";
        Q99.respostacerta = 2;
        Q99.nivel = 10;
        Q99.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q99);

        var Q100 = new Questao();
        Q100.pergunta = "Qual campeão é famoso por sua habilidade de criar globos de neve?";
        Q100.resposta1 = "Nunu e Willump";
        Q100.resposta2 = "Braum";
        Q100.resposta3 = "Lissandra";
        Q100.resposta4 = "Anivia";
        Q100.resposta5 = "Sejuani";
        Q100.imagem = "logo.png";
        Q100.respostacerta = 1;
        Q100.nivel = 10;
        Q100.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
        ListaQuestoes.Add(Q100);

        ProximaPergunta();
    }

}