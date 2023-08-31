/* Exercício 6: Soma com Loop do-while
Desenvolva um programa que utilize um loop do-while para solicitar números inteiros ao usuário. 
Continue somando esses números até que o usuário insira o número 0. Mostre a soma total ao final. */

int parar = 0;
int num;
int resultado = 0;
do
{
    Console.WriteLine("Informe um número: ");
    num = Convert.ToInt32(Console.ReadLine());
    resultado = resultado + num;
} while (num != parar);
    Console.WriteLine($"A soma dos números informados é = {resultado}");