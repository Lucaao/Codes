# Exercício Python #082 - Dividindo valores em várias listas
lista_origi = []
lista_par = []
lista_impar = []
while True:
    numeros = int (input("Digite um número: [0] Finalizar! "))
    if numeros == 0:
        print("Finalizando!")
        break 
    else: 
        lista_origi.append(numeros)    

    if numeros %2 == 0:
        lista_par.append(numeros)
    else:
        lista_impar.append(numeros)
print(f"Original: {lista_origi}")
print(f"Pares: {lista_par}")
print(f"Impares: {lista_impar}")