peso = int (input("Quanto você está pesando atualmente seu hipopótamo? "));  
altura = float (input("Quantos metros você está medindo seu animal? ")); 
imc = peso / (altura ** 2); 
if (imc < 18.5): 
    print ("Você ta abaixo do peso!"); 
elif (imc >= 18.5 and imc < 25): 
    print("Você está no peso ideal seu chinelo!"); 
elif (imc >= 25 and imc <30): 
    print("Você está meio gordo seu merda!"); 
elif (imc >= 30 and imc <40): 
    print("Só da tu e o balão juntos!"); 
else:
    print(f"Ta muito preocupante ta fora da realidade! seu IMC é {imc}"); 