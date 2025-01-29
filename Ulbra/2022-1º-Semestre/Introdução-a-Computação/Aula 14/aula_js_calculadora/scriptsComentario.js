//Percorer o número e identificar o algarismo

function binarioParaDecimal(num){
    var arr = num.split('');
    var resultadoFormula = 0;
    var resultadoFinal = 0;
    for(i=arr.length-1;i>0;i--){
        console.log('número: ' + arr[i]);
        //(a*b^p)
        resultadoFormula = (arr[i] * (2**i));
        resultadoFinal = resultadoFinal + resultadoFormula;
    }
    return resultadoFinal;
}

//INVERTER 1234
function inverter(num){
    var arr = num.split('');
    for(i=arr.length-1;i>=0;i--){
        console.log(arr[i]);
        console.log('Algarismo = ' + arr[i]);
    }
}

function verPares(num){
    arr = num.split('');
    for(i=0;i<arr.length;i++){
        if(arr[i % 2==0])
        console.log(arr[i]);
    }
}

function verTipo(valor){
    console.log(typeof(valor));
}

// cada variável e passa dentro do laço...
// numero = 1010 
// tamanho do array - 1?
// algarismo = arr [i];
//  i         i>0            resultadoFormula      resultadoFinal
//  3         3>0                1*2^3
//  2         2>0                0*2^2




//Transformar decimal para qualquer base


//pega o decimal e divide pela base
//guarda o resto da divisão
//guarda o próximo dividendo
//conceitos
//dividendo,divisor,resto,quociente