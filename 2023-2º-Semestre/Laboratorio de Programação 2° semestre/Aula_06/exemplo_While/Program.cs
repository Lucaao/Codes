/* Exemplo While */

int numeros = 0;
while(numeros <= 5){
    Console.WriteLine(numeros);
    numeros++;
}


/* Exemplos Do While */ 

/* Exemplo 1 */
int numero_secreto = 8;
int palpite;
do{
    Console.WriteLine("Digite um número: ");
    palpite = Convert.ToInt32(Console.ReadLine());
} while (palpite != numero_secreto);
Console.WriteLine("Parabéns você acertou! :)"); 


/* Exemplo 2 */
Console.WriteLine("Informe um número maior que 5");
int num = Convert.ToInt32(Console.ReadLine());
while(num > 5){
    Console.WriteLine("Você digitou um número maior que 5.");
    Console.WriteLine("Informe um número maior que 5");
    num = Convert.ToInt32(Console.ReadLine());
}


/* Exemplo 3 */
int num;
do{
    Console.WriteLine("Informe um número maior que 5");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Você digitou o número {num} ");
    break;
} while (num > 5);

/* Exemplo 4 */
