print("Vamos converter um número em algumas bases!"); 
numero = int (input("Digite um número: ")); 
hexadecimal = hex(numero); 
binario = bin(numero); 
octal = oct(numero); 

print(f"O número {numero} em hexadecimal é {hexadecimal}!"); 
print(f"O número {numero} em binario é {binario}!"); 
print(f"O número {numero} em octal é {octal}!"); 