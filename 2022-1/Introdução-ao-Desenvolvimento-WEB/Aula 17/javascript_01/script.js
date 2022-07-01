
// var resposta = confirm('Você é vegetariano?');

// if(resposta == true){
//     alert('Coma mais proteínas...');
// }else{
//     alert('Coma menos gordura...');
// }


// var email = prompt('Digite seu email');
// alert('O email ' + email + ' será usado para spam');    

// var num1 = parseFloat(prompt('Digite um número'));
// var num2 = parseFloat(prompt('Digite outro número'));

// alert(num1+num2);

// function soma(num1, num2){
//     var resultado = num1 + num2;
//     return resultado;
// }

// var receberResultado = soma(1, 2);
// console.log(receberResultado);

// console.log(soma(2, 6));

// function clicou(){
//     alert('Clicou');
// }

// function lerValor(){
//     var resultado = document.getElementById('valor').value;
//     var conteudo = document.getElementById('resultado').innerHTML
//     document.getElementById('resultado').innerHTML = conteudo + '<br>' + resultado;
// }

function verificar(){
    var termo = document.getElementById('termo').value;
    if(termo!='' && termo!=null){
        return true;
    } else{
        document.getElementById('mensagem').innerHTML = "Digite um termo para pesquisar";
        return false;
    }
}