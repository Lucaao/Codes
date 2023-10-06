/* Exercício 5: Diferentes Atributos
Utilizando a classe Carro criada durante a aula, 
instancie três objetos diferentes e exiba suas propriedades no console. */

Carro carro1 = new Carro();
carro1.marca = "BMW";
carro1.ano = 2023;
carro1.modelo = "X6";

Carro carro2 = new Carro();
carro2.marca = "Mercedez";
carro2.ano = 2020;
carro2.modelo = "AMG 65";

Carro carro3 = new Carro();
carro3.marca = "Gurgel";
carro3.ano = 1991;
carro3.modelo = "X12";

Console.WriteLine($"{carro1.marca}, {carro1.ano}, {carro1.modelo}. \n{carro2.marca}, {carro2.ano}, {carro2.modelo}. \n{carro3.marca}, {carro3.ano}, {carro3.modelo}.");
public class Carro {
    public string? marca;
    public double ano;
    public string? modelo;
}