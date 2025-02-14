velocidade = int (input ("Qual a velocidade atual do carro?\n")); 
if velocidade <= 80:
    print("Você está dentro do limite de velocidade da via!"); 
else: 
    multa = (velocidade - 80) * 7; 
    print(f"!!VOCÊ FOI MULTADO!!\nVocê recebeu uma multa no valor de R${multa} reais!"); 