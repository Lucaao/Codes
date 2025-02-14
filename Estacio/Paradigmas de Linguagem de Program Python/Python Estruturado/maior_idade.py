maior_idade = 0; 
menor_idade = 0; 
for nascimento in range (0, 7): 
    nascimento = int (input("Digite uma data de nascimento: ")); 
    if 2025 - nascimento < 18: 
        menor_idade += 1; 
        print(f"Você é menor de idade!"); 
    elif 2025 - nascimento >= 18: 
        maior_idade += 1; 
        print(f"Você é maior de idade!"); 
print(f"{maior_idade} são maiores de idade!"); 
print(f"{menor_idade} são menores de idade!"); 
