# Exercício Python #085 - Listas com pares e ímpares

lista_origi = []
lista_par = []
lista_impar = []
contador = 1
while len(lista_origi) < 7:
    numeros = int (input(f"Digite o {contador}º número: "))
    contador += 1
    lista_origi = [lista_origi.append(numeros)]    
    if numeros %2 == 0:
        lista_par.append(numeros)
    else:
        lista_impar.append(numeros)
        
lista_origi.sort()
print(f"Original: {lista_origi}")
print(f"Pares: {lista_par}")
print(f"Impares: {lista_impar}")