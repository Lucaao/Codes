/* Exercício 8: Fatorial de um Número
Peça ao usuário para inserir um número inteiro positivo. 
Utilize um loop for para calcular o fatorial desse número. Exiba o resultado no console. */

Console.WriteLine("Por favor insira um número inteiro positivo: ");
int num = Convert.ToInt32(Console.ReadLine());
int fatorial = num;
for (int i = num - 1; i >= 1 ; i--){
    fatorial = fatorial * i;
}
Console.WriteLine(fatorial);