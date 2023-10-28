// Classe equipe e seus atributos, junto com //
// método para fazer a soma total dos pontos e método para adicionar jogadores aos times/equipes //
class Equipe {
    public string NomeEquipe;
    public List<Jogador> jogadores;
    public Equipe (string nomeEquipe){
        NomeEquipe = nomeEquipe;
        jogadores = new List<Jogador>();
    }
    public int PontosTotal(){
        return jogadores.Sum(jogador => jogador.pontos);
    }
    public void AdicionarJogadores(Jogador jogador){
        if (jogadores.Count < 5){
            jogadores.Add(jogador);
            Console.WriteLine($"{jogador.nome} - {jogador.nickname} agora faz parte da equipe {NomeEquipe}.");
        } else{
            Console.WriteLine($"A equipe {NomeEquipe} está cheia, já contém 5 jogadores.");
        }
    }
}