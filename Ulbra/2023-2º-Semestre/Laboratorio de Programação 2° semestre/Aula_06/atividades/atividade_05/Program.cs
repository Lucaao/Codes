/* Exercício 5: Tabuada de um Número Usando for
Crie um programa que solicite ao usuário um número inteiro. Utilize um loop for 
para imprimir a tabuada desse número, de 1 a 10. Mostre cada linha da tabuada no console. */

Console.WriteLine("Informe um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
int tabuada = 0;

for (int i = 1; i <= 10; i++){
    tabuada = num * i;
    Console.WriteLine($"{num} x {i} = {tabuada}");
}