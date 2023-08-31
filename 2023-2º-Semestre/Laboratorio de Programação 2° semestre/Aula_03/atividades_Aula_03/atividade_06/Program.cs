/* 6 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
inválido’: (use o operador condicional ternário) */

/* Pedindo Login e Senha */
Console.WriteLine("Informe seu nome");
string? nome = Console.ReadLine();
Console.WriteLine("Informe sua senha");
int senha = Convert.ToInt32(Console.ReadLine());

/* Validando Login e Senha */
if (nome == "admin" && senha == 123){
    Console.WriteLine("Login feito com sucesso!");
}
else if (nome == "maria" && senha == 123){
    Console.WriteLine("Login feito com sucesso!");
}
else{
    Console.WriteLine("Login inválido!");
}