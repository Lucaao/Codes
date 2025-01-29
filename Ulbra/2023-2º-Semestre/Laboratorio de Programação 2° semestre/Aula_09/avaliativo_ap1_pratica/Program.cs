/* Repetição do código */
do { 
    /* Pede e recebe o nome da pessoa */
    Console.WriteLine("Digite o seu nome: ");
    string? nome = Console.ReadLine();

    /* Pede e recebe a idade */
    Console.WriteLine("Digite a sua idade: ");
    double idade = Convert.ToDouble(Console.ReadLine());

    /* Pede e recebe a altura */
    Console.WriteLine("Digite a sua altura: (00,0) ");
    double altura = Convert.ToDouble(Console.ReadLine());

    /* Pede e recebe o peso */
    Console.WriteLine("Digite o seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    /* Calcula o IMC da pessoa */
    double imc = peso / (altura * altura);

    /* Condição para determinar se a pessoa está abaixo do peso, peso normal, sobrepeso ou obeso */
    /* Se o peso for <18 Baixo peso!  <=25 Peso normal!    <=20 Sobrepeso!    >=30 Obesidade grau 1 */
    string imc_categoria;
    if (imc < 18) {
        imc_categoria = "Abaixo do peso";
    } else if (imc <= 25){
        imc_categoria = "Peso normal";
    } else if (imc <= 29){
        imc_categoria = "Sobrepeso";
    } else if (imc <= 30){
        imc_categoria = "Obesidade grau 1";
    } else {
        imc_categoria = "doidera dai";
    }

    /* Condição para determinar se a pessoa é criança, adolescente, adulto, idoso */
    /* Se a idade for <=12 Criança   <=17 Adolescente     <=59 Adulto  >=60 Idoso */
    string faixa_etaria;
    if (idade <= 12){
        faixa_etaria = "Criança";
    }
    else if (idade <= 17){
        faixa_etaria = "Adolescente";
    }
    else if (idade <= 59){
        faixa_etaria = "Adulto";
    }
    else if (idade >= 60){
        faixa_etaria = "Idoso";
    } else {
        faixa_etaria = "Meu deus";
    }
    /* Mostra na tela Nome, idade, imc, faixa etaria, e a faixa do IMC */
    Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nIMC: {imc}\nFaixa etaria: {faixa_etaria}\nFaixa de peso: {imc_categoria}\n");
    /* Opção para o usúario calcular mais IMC's e faixas etárias */
    Console.WriteLine("[1] Se você quiser calcular o IMC de mais alguma pessoa digite 1!");
    Console.WriteLine("[2] Se você não quiser mais calcular o IMC digite qualquer número!");
    double opcao = Convert.ToDouble(Console.ReadLine());

    /* Condição para calcular ou não, mais IMC's e faixas etárias */
    if (opcao != 1){
        break;
    }
} while (true);