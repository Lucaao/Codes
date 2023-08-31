/* 2. Dia da Semana
Peça ao usuário para inserir um número de 1 a 7. Seu programa deve exibir o dia da semana correspondente, 
onde 1 é domingo e 7 é sábado. Se o número estiver fora desse intervalo, exiba uma mensagem de erro. */

while (true)
{
    Console.WriteLine("Informe um número de 1 a 7");
    double numero = Convert.ToDouble(Console.ReadLine());
    switch (numero)
    {
        case < 1:
            Console.WriteLine("Erro encontrado, o computador ira se desligar em 3 segundos!");
            Console.WriteLine("3..\n2..\n1..");
            break;
        case 1:
            Console.WriteLine("DOMINGO!");
            break;
        case 2:
            Console.WriteLine("SEGUNDA!");
            break;
        case 3:
            Console.WriteLine("TERÇA-FEIRA!");
            break;
        case 4:
            Console.WriteLine("QUARTA-FEIRA!");
            break;
        case 5:
            Console.WriteLine("QUINTA-FEIRA!");
            break;
        case 6:
            Console.WriteLine("SEXTA-FEIRA!");
            break;
        case 7:
            Console.WriteLine("SÁBADO!");
            break;
        case > 7:
            Console.WriteLine("Erro encontrado, o computador ira se desligar em 3 segundos!");
            Console.WriteLine("3..\n2..\n1..");
            break;
        default:
            break;
    }
}