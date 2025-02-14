comeco = int(input("Digite o começo da progressão: ")); 
passo = int(input("Digite o passo da progressão: ")); 
decimo = comeco + (9) * passo; 

for numero in range (comeco, decimo + passo, passo): 
    print(numero); 
print("FIM"); 