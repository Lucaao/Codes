print("U / D / C / M"); 
numero = int (input("Digite um número de 0 a 9999: ")); 
unidade = numero // 1 % 10; 
dezena = numero // 10 % 10; 
centena = numero // 100 % 10; 
milhar = numero // 1000 % 10;  
print(f"Milhar: {milhar}"); 
print(f"Centena: {centena}"); 
print(f"Dezena: {dezena}"); 
print(f"Unidade: {unidade}"); 