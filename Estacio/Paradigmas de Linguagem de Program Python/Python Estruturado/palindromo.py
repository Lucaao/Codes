frase = input ("Digite uma frase e vamos ver se ela é um palindromo: "); 
frase1 = frase [:: - 1]; 

if frase1 == frase: 
    print(f"A frase {frase} é um palindromo."); 
else: 
    print(f"A frase {frase} não é um palindromo."); 