/* 6. Avaliação de Notas
Solicite ao usuário que insira uma nota (0-100). Classifique a nota nas seguintes categorias:
A (90-100)
B (80-89)
C (70-79)
D (60-69)
F (0-59) */

while (true)
{
    Console.WriteLine("Insira sua nota do semestre:");
    double nota = Convert.ToDouble(Console.ReadLine());
    switch (nota)
    {
        case <= 59:
            Console.WriteLine("Você tirou uma nota F!");
            Console.WriteLine("Você foi reprovado!");
            break;
        case <= 69:
            Console.WriteLine("Você tirou uma nota D!");
            Console.WriteLine("Você foi aprovado!");
            break;
        case <= 79:
            Console.WriteLine("Você tirou uma nota C!");
            Console.WriteLine("Você foi aprovado!");
            break;
        case <= 89:
            Console.WriteLine("Você tirou uma nota B!");
            Console.WriteLine("Você foi aprovado!");
            break;
        case >= 90:
            Console.WriteLine("Você tirou uma nota A!");
            Console.WriteLine("Você foi aprovado!");
            break;
        default:
            break;
    }
}