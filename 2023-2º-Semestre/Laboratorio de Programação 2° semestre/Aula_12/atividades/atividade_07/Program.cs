/* Exercício 7: Atributos Numéricos
Crie uma classe Casa que possua os atributos quantidadeDeQuartos, numero e cor. 
Inicialize um objeto e mostre seus atributos. */

Casa casa1 = new Casa();
casa1.quantidadeDeQuartos = 5;
casa1.numero = 199;
casa1.cor = "Branco";
Console.WriteLine($"{casa1.quantidadeDeQuartos}, {casa1.numero}, {casa1.cor}.");
public class Casa {
    public double quantidadeDeQuartos;
    public double numero;
    public string? cor;
}