
numero = 0;  
contador = 0;  
opcao = True; 
media = 0; 
soma = 0; 
maior = 0; 
menor = None; 

while opcao is True:
    print("-=-" * 15); 
    numero = int (input("Digite um número inteiro: ")); 
    contador += 1; 
    soma += numero; 
    media = soma / contador; 
    print("Somando..."); 

    opcao = str (input("Deseja continuar? [S / N]: ")); 
    if (opcao == "N"):
        opcao = False; 
    elif (opcao == "S"):
        opcao = True; 
    elif (opcao != "N" and opcao !="S"):
        print("Opção inválida. Tente novamente!"); 

    if numero > maior:
        maior = numero; 
    elif menor is None or numero < menor : 
        menor = numero; 

print(f"O usuário digitou {contador} números!"); 
print(f"A soma entre os números digitados é {soma}!"); 
print(f"A média entre os números digitados é {media}!"); 
print(f"O maior número digitado foi o {maior}."); 
print(f"O menor número digitado foi o {menor}."); 
print("-=-" * 15); 