numero1 = 0; 
numero2 = 1; 
tamanho = int (input("Qual vai ser o tamanho da sequência FIBONNACI: ")); 
contador = 0; 

while contador < tamanho: 
    sequencia = numero1 + numero2;  
    numero1 = numero2; 
    numero2 = sequencia; 
    contador += 1; 
    print(f"{sequencia}"); 
print("FIM!"); 
