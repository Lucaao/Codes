// Classe campeonato e seus atributos, junto com método para dar inicio a partida e método para mostrar a classificação final do campeonato //
class Campeonato {
    public string NomeCampeonato;
    public List<Equipe> equipesParticipando;
    public Campeonato (string nomeCampeonato){
        NomeCampeonato = nomeCampeonato;
        equipesParticipando = new List<Equipe>();
    }
    public void IniciarPartida(Equipe e1, Equipe e2){
        Console.WriteLine($"Iniciando a partida do campeonato {NomeCampeonato} entre as equipes {e1.NomeEquipe} e {e2.NomeEquipe}.");
        foreach(Jogador jogador in e1.jogadores.Concat(e2.jogadores)){
            jogador.Jogar();
            Console.WriteLine($"{jogador.nickname} fez {jogador.pontos} pontos nessa partida.");
        }
        Console.WriteLine("Partida simulada, resultados atualizados.");
    }
    public void Classificacao(){
        var classificacao = equipesParticipando.OrderByDescending(e => e.PontosTotal());
        Console.WriteLine("Classificação das equipes: ");
        int i = 1;
        foreach (Equipe equipe in classificacao){
            Console.WriteLine($"{i}. {equipe.NomeEquipe} - Pontos: {equipe.PontosTotal()}");
            i++;
        }
    }
}