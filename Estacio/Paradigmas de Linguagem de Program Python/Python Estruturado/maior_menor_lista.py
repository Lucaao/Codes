# Exercício Python #078 - Maior e Menor valores na Lista

lista_num = []; 
for c in range(0,5): 
    numero = int(input("Digite um número: ")); 
    lista_num.append(numero); 

# max = max(lista_num); 
# min = min(lista_num);  

print(f"Os valores digitados foram {lista_num}"); 
print(f"O maior valor digitado foi {max(lista_num)}!"); 
print(f"O menor valor digitado foi {min(lista_num)}"); 

print(lista_num.pop()); 