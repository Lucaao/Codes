print("-=-" * 15); 
print("Calculando Fatorial!"); 
numero = int (input("Digite um número: ")); 
resultado = 1; 
contador = 1; 

while contador <= numero:
    resultado *= contador; 
    contador += 1; 
print (f"O fatorial de {numero} é {resultado}"); 