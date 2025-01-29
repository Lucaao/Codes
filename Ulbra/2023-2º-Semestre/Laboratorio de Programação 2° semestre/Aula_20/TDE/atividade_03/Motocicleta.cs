public class Motocicleta : Veiculo{
    public string? nome;
    public Motocicleta(string Nome){
        this.nome = Nome;
    }
    public override void IniciarMotor(){
        Console.WriteLine($"A moto {nome} está ligando o motor, VRUM VRUM VRUM");
    }
}