/* 4. Ano Bissexto
Peça ao usuário para inserir um ano e determine se é um ano bissexto ou não. */

/*while (true)
{
    Console.WriteLine("Informe um ano");
    int ano = Convert.ToInt32(Console.ReadLine());
    if(DateTime.IsLeapYear(ano)){
        Console.WriteLine("O ano é bissexto!");
    }else{
        Console.WriteLine("O ano não é bissexto!");
    }
} */
while (true){
    Console.WriteLine("Informe um ano");
    int ano = Convert.ToInt32(Console.ReadLine());
    if(ano % 4 == 0 && ano %100 != 0 || ano % 400 == 0){
        Console.WriteLine("O ano é bissexto!");
    } else{
        Console.WriteLine("O ano não é bissexto!");
    }
}
