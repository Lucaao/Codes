homem = 0; 
mulher = 0; 
maior = 0; 
opcao = 0; 

while True: 
    idade = int(input("Digite sua idade: ")); 
    sexo = input("Digite seu sexo M / F: ").upper(); 
    opcao = str (input("Deseja continuar cadastrando pessoas? [S / N]: ")); 

    if opcao == "S":
        print("Continuando!"); 
    elif opcao == "N":
        print("Finalizando!"); 
        break; 
    print("-=-" *15 ) 

    if sexo == "M": 
        homem += 1; 
    elif sexo == "F" and idade < 20: 
        mulher += 1; 
    elif idade >= 18:
        maior += 1; 
print(f"{maior} pessoas são maiores de 18 anos!"); 
print(f"Foram cadastrados {homem} homens!"); 
print(f"{mulher} mulher(es) tem menos de 20 anos."); 