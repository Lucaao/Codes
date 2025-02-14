print("Progressão aritmética!"); 
comeco = int(input("Digite o começo da progressão: ")); 
passo = int(input("Digite o passo da progressão: ")); 
opcao = 10; 
contador = 0; 
total = 0; 


while opcao != 0:
    total = opcao + total; 
    while contador < total : 
        print(comeco)
        comeco += passo; 
        contador += 1; 
    opcao = int (input("Você deseja mostrar mais quantos termos: ")); 

print("FIM!"); 