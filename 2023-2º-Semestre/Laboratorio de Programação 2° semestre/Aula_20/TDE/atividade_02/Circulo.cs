public class Circulo : Forma {
    public int raio;
    public int area;
    public char nome;
    public Circulo(int Raio, char Nome){
        this.raio = Raio;
        this.nome = Nome;
    }
    public override void CalcularArea(){
        Console.WriteLine($"A Área do circulo {nome} é  = {Math.PI*(raio*raio)}.");
    }
} 