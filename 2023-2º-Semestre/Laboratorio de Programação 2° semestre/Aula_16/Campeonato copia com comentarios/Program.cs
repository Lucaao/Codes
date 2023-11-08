// Jogadores //
Jogador j1 = new Jogador();
j1.nome = "Paulo";
j1.nickname = "PaulinhoMatadorXX";
j1.pontos = 0;
j1.Jogar();

Jogador j2 = new Jogador();
j2.nome = "Bento";
j2.nickname = "Bento777";
j2.pontos = 0;
j2.Jogar();

Jogador j3 = new Jogador();
j3.nome = "Bina";
j3.nickname = "TheRealBina";
j3.pontos = 0;
j3.Jogar();

Jogador j4 = new Jogador();
j4.nome = "Pedro";
j4.nickname = "OctopusPrime";
j4.pontos = 0;
j4.Jogar();

Jogador j5 = new Jogador();
j5.nome = "Pablo";
j5.nickname = "Pablito Escobar";
j5.pontos = 0;
j5.Jogar();

Jogador j6 = new Jogador();
j6.nome = "Odair";
j6.nickname = "LoPerito";
j6.pontos = 0;
j6.Jogar();

Jogador j7 = new Jogador();
j7.nome = "Enzo";
j7.nickname = "TheFallenAngel";
j7.pontos = 0;
j7.Jogar();

Jogador j8 = new Jogador();
j8.nome = "Bruna";
j8.nickname = "LaSenorita";
j8.pontos = 0;
j8.Jogar();

Jogador j9 = new Jogador();
j9.nome = "Otavio";
j9.nickname = "AbajurChique";
j9.pontos = 0;
j9.Jogar();

Jogador j10 = new Jogador();
j10.nome = "Lucas";
j10.nickname = "Pindamonhangueba";
j10.pontos = 0;
j10.Jogar();

// Equipe 1 //
Equipe equipe1 = new Equipe ("Imperial");
// Adicionar nome a equipe caso não tivesse o parametro //
//equipe1.NomeEquipe = "Imperial"; //

// Adicionar jogadores //
equipe1.AdicionarJogadores(j1);
equipe1.AdicionarJogadores(j2);
equipe1.AdicionarJogadores(j3);
equipe1.AdicionarJogadores(j4);
equipe1.AdicionarJogadores(j5);

// Equipe 2//
Equipe equipe2 = new Equipe ("Astralis");
// Adicionar nome a equipe caso não tivesse o parametro //
//equipe1.NomeEquipe = "Astralis"; //

// Adicionar jogadores //
equipe2.AdicionarJogadores(j6);
equipe2.AdicionarJogadores(j7);
equipe2.AdicionarJogadores(j8);
equipe2.AdicionarJogadores(j9);
equipe2.AdicionarJogadores(j10);

// Campeonato //
Campeonato campeonato1 = new Campeonato("CSGO Major Torrika");

// Adicionar nome do campeonato, se não tivesse os parametros //
//campeonato1.nomeCampeonato = "CSGO Major Torrika"; //

// Equipes participando do campeonato //
campeonato1.equipesParticipando.Add(equipe1);
campeonato1.equipesParticipando.Add(equipe2);

// Inicio do campeonato //
campeonato1.IniciarPartida(equipe1, equipe2);

// Classificação do campeonato //
campeonato1.Classificacao();