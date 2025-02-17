contador = 0; 
numero = 0; 
soma = 0; 
while numero != 999:
    print("-=-" * 15)
    numero = int (input("Digite um número inteiro: ")); 
    soma += numero; 
    contador += 1; 
    if numero == 999:
        contador -= 1; 
        soma -= 999; 
print(f"O usuário digitou {contador} números!"); 
print(f"A soma entre os números digitados é {soma}!"); 
print("-=-" * 15); 