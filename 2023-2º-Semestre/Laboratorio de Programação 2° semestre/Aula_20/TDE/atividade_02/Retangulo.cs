public class Retangulo : Forma {
    public int lado1;
    public int lado2;
    public int area;
    public char nome;
    public Retangulo(int Lado1, int Lado2, char Nome){
        this.lado1 = Lado1;
        this.lado2 = Lado2;
        this.area = lado1 * lado2;
        this.nome = Nome;
    }
    public override void CalcularArea(){
        Console.WriteLine($"A Área do retângulo {nome} é,  {lado1} * {lado2} = {area}.");
    }
}