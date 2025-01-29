// Classe publica Voo e seus atributos
public class Voo {
    public string? companhiaAerea;
    public string? origem;
    public string? destino;
    public string? dataPartida;
    public int precoPassagem;

    // Construtor para possibilitar a instanciação com parâmetros
    public Voo(string companhiaAerea, string origem, string destino, string dataPartida, int precoPassagem){
        this.companhiaAerea = companhiaAerea;
        this.origem = origem;
        this.destino = destino;
        this.dataPartida = dataPartida;
        this.precoPassagem = precoPassagem;
    }
    public void informacoesVoo(){
        Console.WriteLine($" Informações sobre o Voo da empresa {companhiaAerea} \n Origem: {origem} \n Destino: {destino} \n Data de Partida: {dataPartida} \n Preço da Passagem: R${precoPassagem} \n");
    }
}