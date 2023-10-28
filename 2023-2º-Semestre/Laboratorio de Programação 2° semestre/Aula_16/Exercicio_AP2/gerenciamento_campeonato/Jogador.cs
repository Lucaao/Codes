// Classe jogador e seus atributos, junto com método para gerar pontos aleatorios //
class Jogador {
    public string? nome;
    public string? nickname;
    public int pontos = 0;
    public void Jogar(){
        Random numAleatorio = new Random();
        int pontosPartida = numAleatorio.Next(1,101);
        pontos += pontosPartida;
    }
}