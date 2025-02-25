# Exercício Python #080 - Lista ordenada sem repetições

lista = [];  
pos = 0; 
for c in range (0,5): 
    numero = int(input("Digite um número para a lista: ")); 
    if c == 0 or numero > lista[-1]: 
        lista.append(numero); 
    else:
        while pos < len(lista):
            if numero <= lista[pos]: 
                lista.insert(pos, numero); 
                break; 
            pos +=1; 
print(lista); 