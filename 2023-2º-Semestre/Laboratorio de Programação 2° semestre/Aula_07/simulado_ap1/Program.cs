    /* Repetição do código */
do { 
    /* Pede e recebe o nome do aluno */
    Console.WriteLine("Digite o nome do aluno: ");
    string? nome_aluno = Console.ReadLine();

    /* Pede e recebe a primeira nota do aluno */
    Console.WriteLine("Digite a primeira nota do aluno: ");
    double nota1 = Convert.ToDouble(Console.ReadLine());

    /* Pede e recebe a segunda nota do aluno */
    Console.WriteLine("Digite a segunda nota do aluno: ");
    double nota2 = Convert.ToDouble(Console.ReadLine());

    /* Pede e recebe a terceira nota do aluno */
    Console.WriteLine("Digite a terceira nota do aluno: ");
    double nota3 = Convert.ToDouble(Console.ReadLine());

    /* Calcula a média do aluno */
    double media = (nota1+nota2+nota3) / 3;

    /* Condição para determinar se o aluno foi aprovado ou não */
    /* Se a média for maior ou igual a 7 APROVADO, caso contrário, REPROVADO */
    if (media >= 7){
        Console.WriteLine($"O aluno {nome_aluno} \nNota 1: {nota1} \nNota 2: {nota2} \nNota 3: {nota3} \nteve a média {media} e foi APROVADO(a)!");
    } else {
        Console.WriteLine($"O aluno {nome_aluno} \nNota 1: {nota1} \nNota 2: {nota2} \nNota 3: {nota3} \nteve a média {media} e foi REPROVADO(a)!");
    }

    /* Opção para o usúario calcular mais médias de outros alunos */
    Console.WriteLine("[1] Se você quiser calcular a média de mais um aluno digite 1!");
    Console.WriteLine("[2] Se você não quiser mais calcular a média de nenhum aluno digite qualquer número!");
    double opcao = Convert.ToDouble(Console.ReadLine());

    /* Condição para calcular ou não, mais médias de alunos */
    if (opcao != 1){
        break;
    }
} while (true);