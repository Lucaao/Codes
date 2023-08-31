/* Exercício 7: Encontrar o Primeiro Múltiplo de 3 e 7
Utilize um loop for e a palavra-chave break para procurar o 
primeiro número que seja múltiplo tanto de 3 quanto de 7, dentro do intervalo de 1 a 100. Exiba esse número no console. */

int multiplo = 0;
for (int i = 1; i < 100; i++){
    if (i % 3 == 0 && i % 7 == 0){
        multiplo = i;
        break;
    }
} Console.WriteLine($"{multiplo} é múltiplo de 3 e 7");