/* 3- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
a concatenação e também a interpolação de string */

Console.WriteLine("Informe uma letra");
string? letra1 = Console.ReadLine();
Console.WriteLine("Informe uma letra");
string? letra2 = Console.ReadLine();
Console.WriteLine("Informe uma letra");
string? letra3 = Console.ReadLine();

/* Interpolação */
Console.WriteLine($"A ordem reversa das letras é {letra3} {letra2} {letra1}");

/* Concatenação */
Console.WriteLine("A ordem reversa das letras é " + letra3 + letra2 + letra1);