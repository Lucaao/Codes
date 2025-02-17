while True:
    print("-=-" * 15); 
    numero = int (input("Digite um número para fazer a tabuada: ")); 
    if (numero <= 0): 
        break; 
    for tabuada in range (1, 11):
        print(f"{numero} x {tabuada} = {numero*tabuada}"); 
print("-=-" * 15); 
print("FIM"); 