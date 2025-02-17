soma = 0; 
numero = int (input ("Digite um número: ")); 
while True: 
    print(f"{soma}"); 
    if  soma >= 10 : 
        print("Parou!"); 
        break; 
    soma += numero; 
print(f"A soma é {soma}"); 
