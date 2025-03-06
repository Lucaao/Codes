# Exercício Python #086 - Matriz em Python

matriz3x3 =[[0,0,0], 
            [0,0,0], 
            [0,0,0]]

for linha in range(0,3): 
    for coluna in range(0,3):
        matriz3x3[linha][coluna]= int(input(f"Digite um valor para {[linha, coluna]}: "))
print("-=-" * 9)
for linha in range(0,3):
    for coluna in range(0,3): 
        print(f"[{matriz3x3[linha][coluna]:^7}]", end = "")
    print("")
