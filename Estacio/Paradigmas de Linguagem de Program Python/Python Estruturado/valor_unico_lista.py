# Exercício Python #079 - Valores únicos em uma Lista

'''lista = []; 
opcao = True; 

''while opcao is True: 
    numeros = int (input("Digite um número: ")); 
    if numeros not in lista: 
        print("Adicionando número na lista!"); 
        lista.append(numeros); 
    elif numeros in lista: 
        print("Não vou adicionar!"); 
    opcao = str (input("Dseseja continuar? [S / N] ")); 
    if opcao == "S": 
        opcao = True; 
    elif opcao == "N": 
        opcao == False; 
lista.sort(); 
print(lista); '''''

'''lista = []; 
while True: 

    opcao = int(input("Digitar um número:  \n[0] Finalizar! "))
    if opcao == 0:
        print("Finalizando!"); 
        break; 
    if opcao not in lista: 
        lista.append(opcao); 
lista.sort(); 
print(lista); '''