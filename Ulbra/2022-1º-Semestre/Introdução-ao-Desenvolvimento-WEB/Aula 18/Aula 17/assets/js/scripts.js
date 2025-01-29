//Parte 01
function calcular(){
    var num1 = parseFloat(document.getElementById('num1').value);
    var num2 = parseFloat(document.getElementById('num2').value);
    var operacao = document.getElementById('operacao').value;
    var total;
    switch (operacao){
        case '+':
            total= num1+num2;
            break;
        case '-':
            total= num1-num2;
            break;
        case '*':
            total= num1*num2;
            break;
        case '/':
            total= num1/num2;
            break;
        default:
            break;
    }
    document.getElementById('total').innerHTML = ('O resultado é: ' + total);
}

//Parte 02
function calcularConta(){
    var quantidadeKwh = parseFloat(document.getElementById('quantidadeKwh').value);
    var valorKwh = parseFloat(document.getElementById('valorKwh').value);
    var valorConta = quantidadeKwh * valorKwh;

    if(quantidadeKwh>100 && quantidadeKwh<=200){
        valorConta = valorConta * 1.25;
    }else if(quantidadeKwh>200){
        valorConta = valorConta*1.5;
    }
    document.getElementById('valorConta').innerHTML='O valor da conta é de R$ ' + valorConta;
}

//Parte 03
function verificarMaior(){
    var numeros = document.getElementById('numeros').value;
    numeros = numeros.split(',');
    var maior = 0;

    for(i=0;i<numeros.length;i++){
        var valorAtual = parseFloat(numeros[i]);
        if(valorAtual>maior){
            maior = valorAtual;
        }
    }
    document.getElementById('maiorNumero').innerHTML= ('O maior valor é ' + maior);
}

//Parte 04
function verificarIdades(){
    var idades = document.getElementById('idades').value;
    idades = idades.split(',');
    
    var menoresDeIdade = 0;
    var maioresDeIdade = 0;

    for(i=0;i<idades.length;i++){
        var idadeAtual = parseFloat(idades[i]);

        if(idadeAtual<18){
            menoresDeIdade++;
        }else{
            maioresDeIdade++;
        }
    }
    document.getElementById('mostraIdades').innerHTML= menoresDeIdade + ' pessoas são menores de idade e ' + maioresDeIdade + ' pessoas são maiores de idade'
}