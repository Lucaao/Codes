
function numeroToDecimal(num, base){

    var arr = num.split('');

    var resultadoFormula = 0;
    var resultadoFinal = 0;
    var posicao = arr.length-1;
    var algarismo = 0;

    for(i=0;i<arr.length;i++){
        //(a*b^p)
        if(base==16){
            algarismo = hexaToDecimal(arr[i]);
        }else{
            algarismo = arr[i];
        }
        resultadoFormula = (algarismo * (base**posicao));
        resultadoFinal = resultadoFinal + resultadoFormula;
        posicao--;
    }

    return resultadoFinal;
}

function hexaToDecimal(letra){
    var numero=0;

    switch (letra) {
        case 'A':
            numero = 10;
            break;
        case 'B':
            numero = 11;
            break;
        case 'C':
            numero = 12;
            break;
        case 'D':
            numero = 13;
            break;
        case 'E':
            numero = 14;
            break;
        case 'F':
            numero = 15;
            break;
        default:
            numero = letra;
            break;
    }
    return numero;
}

function decimalToBases(num,base){
    var resto = 0;
    var dividendo = num;
    var i = 0;
    var resultado = '';

    while(i == 0){
        
        resto = dividendo % base;
        dividendo = parseInt(dividendo/base);
        if(base===16 && (resto>=10 && resto<=15)){
            resto = decimalToHexa(resto);
        }
        resultado = resultado + resto;

        if(dividendo < base){
            i++;
            if(base===16 && (dividendo>=10 && dividendo<=15)){
                dividendo = decimalToHexa(dividendo);
            }
            resultado = resultado + dividendo;
        }
    }
    return inverterNum(resultado);
}

function inverterNum(num){
    var result = '';
    var arr = num.split(''); 
    for(i=arr.length-1; i>=0; i--){
        result+=arr[i];
    }
    return result;
}

function decimalToHexa(numero){
    var letra="";

    switch (numero) {
        case 10:
            letra = "A";
            break;
        case 11:
            letra = "B";
            break;
        case 12:
            letra = "C";
            break;
        case 13:
            letra = "D";
            break;
        case 14:
            letra = "E";
            break;
        case 15:
            letra = "F";
            break;
        default:
            letra = numero;
            break;
    }
    return letra;
}