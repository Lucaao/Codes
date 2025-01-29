/* 7 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :) */

/* Recebendo números */
Console.WriteLine("Informe um número X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe um número Y");
int y = Convert.ToInt32(Console.ReadLine());

/* Validando se é par ou impar */
if (x %2 == 0){
    Console.WriteLine("O número X informado é par!");
}
else{
    Console.WriteLine("O número X informado é impar!");
}

if (y %2 == 0){
    Console.WriteLine("O número Y informado é par!");
}
else{
    Console.WriteLine("O número Y informado é impar!");
}