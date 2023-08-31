/* Entrada de dados */

string nome = Console.ReadLine();
Console.WriteLine($"O seu nome é {nome}");

Console.WriteLine("Informe sua idade");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A sua idade é {idade}");


/* Operadores aritméticos */

Console.WriteLine("Informe o valor de X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

/* Math. */

Console.WriteLine($"Raiz quadrada de X é = {Math.Sqrt(x)}");
Console.WriteLine($"A potência de X elevado a Y é = {Math.Pow(x,y)}");
Console.WriteLine($"Valor minimo entre X e Y = {Math.Min(x, y)}");
double valor = Math.PI;

double divisao = (double) x / y;
Console.WriteLine($"A divisão de X de Y é igual {divisao}");
