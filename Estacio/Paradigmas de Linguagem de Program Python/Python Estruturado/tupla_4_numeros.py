# Exercício Python #075 - Análise de dados em uma Tupla

numeros = tuple(int (input("Digite um número: ")) for n in range(0,4)); 

nove = numeros.count(9); 
if 3 in numeros: 
    tres = numeros.index(3); 
    print(f"O número 3 apareceu pela primeira vez na posição {tres}!"); 
def pares (tupla):
    for num in tupla:
        if num % 2 == 0: 
            print(f"Estes foram os números pares na tupla {num}!"); 

print(f"O número 9 apareceu {nove} vezes!"); 
pares(numeros); 