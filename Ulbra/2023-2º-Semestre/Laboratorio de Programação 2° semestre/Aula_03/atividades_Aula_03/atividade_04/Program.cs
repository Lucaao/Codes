/* 4- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
exibindo o resultado */

Console.WriteLine("Insira um valor");
double valor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira um segundo valor");
double valor2 = Convert.ToInt32(Console.ReadLine());

/* Soma */
double soma = (double) valor1 + valor2;
/* Subtração */
double subtracao = (double) valor1 - valor2;
/* Multiplicação */
double multiplicacao = (double) valor1 * valor2;
/* Divisão */
double divisao = (double) valor1 / valor2;
/* Exponenciação */
double exponenciacao = (double) Math.Pow(valor1,valor2);
/* Valor real / MÓDULO 1 */
double modulo1 = (double) Math.Abs(valor1);
/* Valor real / MÓDULO 2 */
double modulo2 = (double) Math.Abs(valor2);

/*Resultado Soma*/
Console.WriteLine($"A soma de {valor1} + {valor2} é = {soma}");
/*Resultado Subtração*/
Console.WriteLine($"A subtração de {valor1} - {valor2} é = {subtracao}");
/*Resultado Multiplicação*/
Console.WriteLine($"A multiplicação de {valor1} * {valor2} é = {multiplicacao}");
/*Resultado Divisão*/
Console.WriteLine($"A divisão de {valor1} / {valor2} é = {divisao}");
/*Resultado Exponenciação*/
Console.WriteLine($"A exponenciação de {valor1} em {valor2} é = {exponenciacao}");
/*Resultado Valor real / MÓDULO 1*/
Console.WriteLine($"O valor real de {valor1} é = {modulo1}");
/*Resultado Valor real / MÓDULO 2*/
Console.WriteLine($"O valor real de {valor2} é = {modulo2}");