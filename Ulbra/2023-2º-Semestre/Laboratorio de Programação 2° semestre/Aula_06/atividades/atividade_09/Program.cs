/* Exercício 9: Série de Fibonacci até N
Solicite ao usuário que insira um número inteiro N. Utilize um loop de sua escolha para imprimir a 
série de Fibonacci até o N-ésimo termo. Cada termo da série deve ser exibido no console. */

Console.WriteLine("Insira um número inteiro");
int num = Convert.ToInt32(Console.ReadLine());
int soma;
int a = 0;
int b = 1;
for (int i = 0; i < num; i++){
    soma = a +b;
    a = b;
    b = soma;
    Console.WriteLine($"{soma} A soma de {a} + {b} é = ");
}
