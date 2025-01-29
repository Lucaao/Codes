/* Exercício 4: Sair Quando o Quadrado For Maior que 50
Escreva um programa que utilize um loop while e a palavra-chave break. O programa deve calcular os quadrados dos números inteiros 
começando com 1 e parar assim que um quadrado maior que 50 for encontrado. Exiba esse valor no console. */

int quadrado = 1;
int resultado = 0;
while (quadrado <= 50)
{
    resultado = Convert.ToInt32(Math.Pow(quadrado,2));
    if(resultado > 50){
        break;
    }
    quadrado ++;
} 
    Console.WriteLine($"{quadrado} ao quadrado = {resultado}, é maior que 50");