/* 5. Calculadora Básica
Escreva um programa que peça ao usuário dois 
números e uma operação (soma, subtração, multiplicação, divisão). Use uma estrutura switch para realizar a operação escolhida e exiba o resultado. */

while (true)
{
    Console.WriteLine("Informe um número");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe o segundo número");
    double num2 = Convert.ToDouble(Console.ReadLine());
    while (true)
    {
        Console.WriteLine("Escolha a operação!");
        Console.WriteLine("(1) Soma");
        Console.WriteLine("(2) Subtração");
        Console.WriteLine("(3) Multiplicação");
        Console.WriteLine("(4) Divisão");
        Console.WriteLine("(5) Fechar");
        double opcao = Convert.ToDouble(Console.ReadLine());
    
        switch (opcao)
        {
            case 1:
                double soma = num1 + num2;
                Console.WriteLine($"\nA soma de {num1} + {num2} é {soma}\n");
                break;
            case 2:
                double subtracao = num1 - num2;
                Console.WriteLine($"\nA subtração de {num1} - {num2} é {subtracao}\n");
                break;
            case 3:
                double multiplicacao = num1 * num2;
                Console.WriteLine($"\nA multiplicação de {num1} * {num2} é {multiplicacao}\n");
                break;
            case 4:
                double divisao = num1 / num2;
                Console.WriteLine($"\nA divisão de {num1} / {num2} é {divisao}\n");
                break;
            case 5:
                return;
            default:
                break;
        } 
    }
}