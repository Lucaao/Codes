/* Exercício 3: Classe CalculadoraSimples
Classe: CalculadoraSimples
Métodos: Sobrecargas do método Somar(int a, int b) e Somar(int a, int b, int c)
Descrição: Crie métodos que retornem a soma dos parâmetros passados. Não utilize atributos. */

CalculadoraSimples calculadora = new CalculadoraSimples ();
int resultado1 = calculadora.Somar(10, 5);
int resultado2 = calculadora.Somar(10, 5, 10);
Console.WriteLine($"A soma é {resultado1}.");
Console.WriteLine($"A soma é {resultado2}.");