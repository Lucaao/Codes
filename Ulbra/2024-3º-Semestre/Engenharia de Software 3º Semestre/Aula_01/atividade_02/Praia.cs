// Classe Praia com seus atributos
public class Praia {
    public string? nome;
    public string? localizacao;
    public int temperaturaAgua;
    public string? tipoAreia;

    // Construtor para poder instanciar com parâmetros
    public Praia(string nome, string localizacao, int temperaturaAgua, string tipoAreia){
        this.nome = nome;
        this.localizacao = localizacao;
        this.temperaturaAgua = temperaturaAgua;
        this.tipoAreia = tipoAreia;
    }
    
    // Método para gerar a ação de mostrar todas informações da PRAIA
    public void informacoesPraia(){
        Console.WriteLine($" Informações sobre a praia -{nome}- \n Localização: {localizacao} \n Temperatura da Água: {temperaturaAgua}ºC \n Tipo da Areia: {tipoAreia}.\n ");
    }
}