# Exercício Python #087 - Mais sobre Matriz em Python
soma_pares = 0; 
soma_terceira_coluna = 0; 
maior = 0; 
matriz3x3 =[[0,0,0], [0,0,0], [0,0,0]]

for linha in range(0,3): 
    for coluna in range(0,3):
        matriz3x3[linha][coluna]= int(input(f"Digite um valor para {[linha, coluna]}: "))
print("-=-" * 9)

for linha in range(0,3):
    for coluna in range(0,3): 
        print(f"[{matriz3x3[linha][coluna]:^7}]", end = "")
    print("")

for linha in matriz3x3:
    for elemento in linha:
        if elemento %2 == 0:
            soma_pares += elemento

for linha in matriz3x3:
    soma_terceira_coluna += linha[2]
for numero in matriz3x3[1]:
    if numero > maior:
        maior = numero
print(f"A soma dos valores pares é {soma_pares}!")
print(f"A soma dos valores da terceira coluna é {soma_terceira_coluna}!")
print(f"O maior valor da segunda linha é {maior}!")
