namespace Milhao;

public class Gerenciador
{

    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao questaoCorrente;

    public Gerenciador(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5, Image compImg)
    {
        CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, compImg);
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
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Burro", "Você errou, é facil desacreditar de você, dificil é acreditar que você consegue! Aqui, é só regresso! ;)", "Ok");
            Inicializar();
        }
    }

    public int Pontuacao { get; private set; }

    int NivelAtual = 0;

    void Inicializar()
    {
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
        Q1.imagem = "logo.jpg";
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
        Q2.imagem = "logo.jpg";
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
        Q3.imagem = "logo.jpg";
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
        Q4.imagem = "logo.jpg";
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
        Q5.imagem = "logo.jpg";
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
        Q6.imagem = "logo.jpg";
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
        Q7.imagem = "logo.jpg";
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
        Q8.imagem = "logo.jpg";
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
        Q9.imagem = "logo.jpg";
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
        Q10.imagem = "logo.jpg";
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
        Q11.imagem = "logo.jpg";
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
        Q12.imagem = "logo.jpg";
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
        Q13.imagem = "logo.jpg";
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
        Q14.imagem = "logo.jpg";
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
        Q15.imagem = "logo.jpg";
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
        Q16.imagem = "logo.jpg";
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
        Q17.imagem = "logo.jpg";
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
        Q18.imagem = "logo.jpg";
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
        Q19.imagem = "logo.jpg";
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
        Q20.imagem = "logo.jpg";
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


    }

}