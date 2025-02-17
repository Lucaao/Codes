from random import randint
print("-=-" * 15); 
print("Vamos jogar PAR ou IMPAR!"); 
print("-=-" * 15); 
contador = 0; 
opcao = 0; 
soma = 0; 
while True:
    numero = int (input("Digite um número: ")); 
    pc = randint (0,10); 
    soma = numero + pc; 
    opcao = str (input("PAR ou IMPAR? [P / I]: ")); 

    print(f"Você jogou {numero} e o PC jogou {pc}."); 
    print(f"Total de {soma}!"); 
    if soma % 2 == 0 and opcao == "P" or soma % 2 != 0 and opcao == "I": 
        print("Você venceu!"); 
        print("Vamos jogar novamente!"); 
        contador += 1; 
    else: 
        print ("Você perdeu!"); 
        break; 
print(f"Você ganhou {contador} vez(es) consecutivas!"); 
print("FIM!"); 

