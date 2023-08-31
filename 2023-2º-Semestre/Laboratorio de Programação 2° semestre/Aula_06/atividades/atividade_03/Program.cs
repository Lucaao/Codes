/* Exercício 3: Pular Números Ímpares
Desenvolva um programa que utilize um loop for e a palavra-chave continue para imprimir todos os números pares entre 1 e 20. Evite imprimir os números ímpares. */

for (int num = 1; num <=20; num ++){
    if (num % 2 != 0){
        Console.WriteLine($"Número impar: {num}");
    }
}