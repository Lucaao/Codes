/* Exemplo de For
for (int i = 0; i <= 50; i++){
    Console.WriteLine(i);
} */

/* Tabuada do 5 */
for (int contador = 1; contador <=10; contador++){
    Console.WriteLine($"5 x {contador} = {5*contador}");
}

/* Soma dos números de 1 a 10 */
int soma = 0;
for (int i = 1; i <=10; i++){
    soma = soma + i;
}
Console.WriteLine(soma);