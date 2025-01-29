/* 1. Positivo, Negativo ou Zero?
Escreva um programa que leia um número do usuário e determine se ele é positivo, negativo ou zero. */

/* Switch case */
while (true){
    Console.WriteLine("Informe um número");
    double numero = Convert.ToDouble(Console.ReadLine());

    switch (numero)
    {
        case < 0.0:
            Console.WriteLine("Esse número é negativo!");
            break;
        case > 0.0:
            Console.WriteLine("Esse número é positivo!");
            break;
        case 0:
            Console.WriteLine("Esse número é zero!");
            break;
        default:
            break;
    }
}

/* IF */
while(false){
    Console.WriteLine("Informe um número");
    double numero = Convert.ToDouble(Console.ReadLine());
    if(numero > 0.0){
        Console.WriteLine("Esse número é positivo!");
    }
    if(numero < 0.0){
        Console.WriteLine("Esse número é negativo!");
    }
    if(numero == 0){
        Console.WriteLine("Esse número é zero!");
    }
}