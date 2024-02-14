public class TocadorDeMúsica : IReproduzível{
    public void Reproduzir(string musica){
        Console.WriteLine($"O tocador de música está reproduzindo {musica}!");
    }
    public void Pausar(string musica){
        Console.WriteLine($"O tocador de música está pausando {musica}!");
    }
    public void Parar(string musica){
        Console.WriteLine($"O tocador de música está parando de tocar {musica}!");
    }
}