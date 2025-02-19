cinquenta = vinte = dez = cinco = dois = um = 0; 

while True:
    valor = int (input("Digite o valor que deseja sacar: ")); 
    if valor >= 50:
        cinquenta = valor // 50; 
        valor = valor % 50; 
    if valor >= 20:
        vinte = valor // 20; 
        valor = valor % 20; 
    if valor >= 10: 
        dez = valor // 10; 
        valor = valor % 10; 
    if valor >= 2:
        dois = valor // 2; 
        valor = valor % 2; 
    if valor >= 1: 
        um = valor // 1; 
        valor = valor % 1; 

    if cinquenta > 0: 
        print (f"Você precisa de {cinquenta} notas de cinquenta!"); 
    if vinte > 0: 
        print (f"Você precisa de {vinte} notas de vinte!"); 
    if dez > 0: 
        print (f"Você precisa de {dez} notas de dez!"); 
    if cinco > 0: 
        print (f"Você precisa de {cinco} notas de cinco!"); 
    if dois > 0:
        print (f"Você precisa de {dois} notas de dois!");  
    if um > 0: 
        print (f"Você precisa de {um} notas de um!"); 

    opcao = str (input("Você deseja continuar? [S / N] ")); 
    if opcao == "S":
        print("Continuando!"); 
    elif opcao == "N":
        print("Finalizando!"); 
        break; 