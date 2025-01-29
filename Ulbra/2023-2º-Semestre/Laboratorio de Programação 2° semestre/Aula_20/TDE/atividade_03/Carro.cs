public class Carro : Veiculo{
    public string? nome;
    public Carro(string Nome){
        this.nome = Nome;
    }
    public override void IniciarMotor(){
        Console.WriteLine($"O carro {nome} está ligando o motor, FIIIIIUUUUU PAPAAPAP FIIIIIIU PAPAPAPPA");
    }
}