/* 3. Faixas Etárias
Crie um programa que leia a idade do usuário e categorize-a nas seguintes faixas etárias:
Criança (0-12 anos)
Adolescente (13-18 anos)
Adulto (19-59 anos)
Idoso (60 anos ou mais) */

while (true)
{
    Console.WriteLine("Informe a sua idade");
    double idade = Convert.ToDouble(Console.ReadLine());
    switch (idade)
    {
        case < 0:
            Console.WriteLine("Errado!");
            break;
        case <= 12:
            Console.WriteLine("Criança!");
            break;
        case <= 18:
            Console.WriteLine("Adolescente!");
            break;
        case <= 59:
            Console.WriteLine("Adulto!");
            break;
        case >= 60:
            Console.WriteLine("Idoso!");
            break;
        default:
            break;
    }
}