# Exercício Python #081 - Extraindo dados de uma Lista

lista = []; 
opcao = True; 

while True:
    numero = int (input("Digite um número para a lista:\n[0] Finalizar ")); 
    lista.append(numero); 
    if numero == 0:
        print("Finalizando!"); 
        break; 

decrescente = sorted(lista, reverse=True); 
digitados = len(lista); 
print(f"Lista em decrescente: {decrescente}!"); 
print(f"Foram digitados {digitados} números!"); 
if 5 in lista: 
    print("\nO 5 está na lista!"); 
else: 
    print("\nO 5 não está na lista!"); 
