# Fazer ATIVIDADE 75 Tupla 
# 1) Quantas vezes apareceu o Nº 9.
# 2) Em que posição foi digitado o primeiro valor 3.
# 3) Quais foram os números pares. 

pares = 0; 
print("Tupla com valores!"); 
numeros = tuple(int(input("Digite um número: "))for num in range(4)); 
if numeros % 2 == 0: 
    pares = numeros; 
    print(pares); 

print(numeros.count(9)); 
