public class TocadorDeVideo : IReproduzível{
    public void Reproduzir(string musica){
        Console.WriteLine($"O tocador de video está reproduzindo {musica}!");
    }
    public void Pausar(string musica){
        Console.WriteLine($"O tocador de video está pausando {musica}!");
    }
    public void Parar(string musica){
        Console.WriteLine($"O tocador de video está parando de tocar {musica}!");
    }
}