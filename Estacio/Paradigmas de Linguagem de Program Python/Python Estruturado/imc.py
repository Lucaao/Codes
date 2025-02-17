peso = int (input("Quanto você está pesando atualmente? "));  
altura = float (input("Quantos metros você está medindo? ")); 
imc = peso / (altura ** 2); 
if (imc < 18.5): 
    print ("Você ta abaixo do peso!"); 
elif (imc >= 18.5 and imc < 25): 
    print("Você está no peso ideal!"); 
elif (imc >= 25 and imc <30): 
    print("Você está meio gordo!"); 
elif (imc >= 30 and imc <40): 
    print("Ta complicado amigo!"); 
else:
    print(f"Ta muito preocupante ta fora da realidade! seu IMC é {imc}"); 