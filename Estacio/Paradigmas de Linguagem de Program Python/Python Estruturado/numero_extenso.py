numero_extenso = ('zero','um','dois','tres','quatro','cinco','seis','sete','oito','nove','dez','onze','doze','treze','quatorze','quinze',
                'dezesseis','dezessete','dezoito','dezenove','vinte','vinte e um','vinte e dois','vinte e tres','vinte e quatro',
                'vinte e cinco','vinte e seis','vinte e sete','vinte e oito','vinte e nove','trinta'); 

while True:
    numero = str (input("Digite um número entre 0 e 30: \nDigite 'SAIR' para encerrar! ")).upper();  
    if numero == "SAIR":
        print("Saindo!"); 
        break; 
    
    if 0 <= int(numero) <= 30: 
        print(f"O número que você digitou é {numero_extenso[int(numero)]}!"); 
        print("-=-" * 15); 
print("-=-" * 15); 