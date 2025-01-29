/* Exercício 1: Soma de Números de 1 a 10
Escreva um programa que utilize um loop for para calcular e exibir na tela a soma dos números inteiros de 1 a 10. Mostre o resultado final após o loop. */

int soma = 0;
for (int num = 1; num <=10; num++){
    soma = soma + num; 
}
    Console.WriteLine($"A soma dos números de 1 a 10 é = {soma}");