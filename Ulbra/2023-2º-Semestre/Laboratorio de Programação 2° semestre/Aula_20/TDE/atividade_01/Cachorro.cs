public class Cachorro : Animal{
    public string? nome;
    public override void FazerSom(){
        Console.WriteLine($"O {nome} está acoando, AU AU RUFF RUFF");
    }
}