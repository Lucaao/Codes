media_idade = 0; 
homem = 0; 
mulher = 0; 
maior = 0; 
mulher_menor = 0; 
nome_velho = ""; 

for pessoas in range(1,5):
    nome = input("Digite seu nome: "); 
    idade = int(input("Digite sua idade: ")); 
    sexo = input("Digite seu sexo M / F: "); 
    print("-=-" *15 )
    media_idade += idade; 
    if sexo == "M" and idade > maior: 
        homem += 1; 
        maior = idade; 
        nome_velho = nome; 
    elif sexo == "F" and idade < 20: 
        mulher += 1; 

print(f"A média da idade do grupo é {media_idade / 4} anos."); 
print(f"O homem mais velho do grupo é o {nome_velho}!"); 
print(f"{mulher} mulheres são menores de 20 anos."); 