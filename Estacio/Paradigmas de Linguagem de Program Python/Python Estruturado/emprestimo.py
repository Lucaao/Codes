salario = int (input("Digite seu salário: ")); 
valor_da_casa = int (input("Digite o custo da casa: ")); 
tempo = int (input("Em quanto tempo você pretende pagar a casa? ")); 

valor_da_mensalidade = valor_da_casa / (tempo *12); 

if valor_da_mensalidade > salario * 0.3: 
    print("Empréstimo negado, você é assim um sonho pra mim!"); 
elif valor_da_mensalidade <= salario * 0.3: 
    print("Empréstimo aprovado, até que você é bem riquinho!"); 