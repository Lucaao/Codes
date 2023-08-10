//* VERIFICAR SE UM NÚMERO É MAIOR/MENOR OU IGUAL 10
function verificar(){
    var valor = parseFloat(prompt('Digite um valor'));
    if(valor>10){
        alert("O número " + valor + " é maior que 10");
    }else if(valor<10){
        alert("O número " + valor + " é menor que 10");
    }else if(valor==10){
        alert("O número " + valor + " é igual a 10");
    }
}

//* SOMAR 2 NÚMEROS
function somar(){
    var num1 = parseFloat(prompt('Digite um valor'));
    var num2 = parseFloat(prompt('Digite um valor'));
    var resultado = num1+num2;
    alert("A soma de " + num1 + "+" + num2 + " é " + resultado);
}

//* ESCOLHER 2 NÚMEROS E UMA OPERAÇÃO
function calcular(oper,num1,num2){
    var num1 = parseFloat(prompt('Digite um valor'));
    var num2 = parseFloat(prompt('Digite um valor'));
    var oper = prompt('Escolha a operação (+, -, *, /)')
    var total=0;
    switch (oper) {
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
            total=undefined;
            break;
    }
    alert(total);
    return total;
}

//*LAÇO PARA REPETIR NOME
function lerNome(){
    var nome = prompt('Digite seu nome');
    var vezes = parseFloat(prompt('Digite um número'));
    for(i=0;i<vezes;i++){
        alert(nome);
    }
}

//*ARMAZENAR NOME E MEIAL NUM ARRAY
function nomeEmail(){
    var dados=[];
    dados[0] = prompt('Digite o nome: ');
    dados[1] = prompt('Digite o endereço: ');
    dados[2] = prompt('Digite o email: ');
    alert('Boa noite ' + dados[0] + ' , seu endereço é' + dados[1] + ' e seu email é' + dados [2]);
}