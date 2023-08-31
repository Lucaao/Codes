/* 5- Faça um programa para calcular o resultado da fórmula de bhaskara dados os valores de
a b e c .
Valores : a = 1 , b = 12 e c = -13 */

/* Variaveis */
int a = 1;
int b = 12;
int c = -13;

/* Delta e Raiz quadrada */
double delta = (b * b) - (4 * a * c);
double raiz = Math.Sqrt(delta);

/* X1+ e X2- */
var x1 = ((-(b)) + raiz ) / (2 * a);
var x2 = ((-(b)) - raiz )/ (2 * a);

Console.WriteLine($"Valor de X1 = {x1} \nValor de X2 = {x2}");
