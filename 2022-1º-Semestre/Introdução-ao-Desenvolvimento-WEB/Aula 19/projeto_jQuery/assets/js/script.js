$(document).ready(function(){

    function removeCss(){
        $('#menu_home').removeClass('active')
        $('#menu_calculadora').removeClass('active')
        $('#menu_conta_luz').removeClass('active')
        $('#menu_verificar_maiores').removeClass('active')
        $('#menu_verificar_idades').removeClass('active')
    }

    $('#menu_home').click(function(){
        $('#menu_home').addClass('active')
        $('section').load('paginas/home.html',function(){
        })
    })

    //Calculadora
    $('#menu_calculadora').click(function(){
        removeCss()
        $('#menu_calculadora').addClass('active')
        $('section').load('exercicios/calculadora.html', function(){
            $('#calcular').click(function(){
                var num1 = parseFloat($('#num1').val())
                var num2 = parseFloat($('#num2').val())
                var operacao = $('#operacao').val()
                var total
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
                $('#total').html('O resultado é: ' + total);
            })
        })
    })

    //Conta de Luz
    $('#menu_conta_luz').click(function(){
        removeCss()
        $('#menu_conta_luz').addClass('active')
        $('section').load('exercicios/conta_luz.html',function(){
            $('#calcular_conta').click(function(){
                var quantidadeKwh = parseFloat($('#quantidadeKwh').val())
                var valorKwh = parseFloat($('#valorKwh').val())
                var valorConta = quantidadeKwh * valorKwh

                if(quantidadeKwh>100 && quantidadeKwh<=200){
                    valorConta = valorConta * 1.25;
                }else if(quantidadeKwh>200){
                    valorConta = valorConta*1.5;
                }
                $('#valorConta').html('O valor da conta é de R$ ' + valorConta)
            })
        })
    })

    //Verificar Maiores que 10
    $('#menu_verificar_maiores').click(function(){
        removeCss()
        $('#menu_verificar_maiores').addClass('active')
        $('section').load('exercicios/verificar_maior.html',function(){
            $('#verificar_maior').click(function(){
                var numeros = $('#numeros').val()
                numeros = numeros.split(',')
                var maior = 0;

                for(i=0;i<numeros.length;i++){
                    var valorAtual = parseFloat(numeros[i]);
                    if(valorAtual>maior){
                        maior = valorAtual;
                    }
                }
                $('#maiorNumero').html('O maior valor é ' + maior)
            })
        })
    })

    //Verificar Idades
    $('#menu_verificar_idades').click(function(){
        removeCss()
        $('#menu_verificar_idades').addClass('active')
        $('section').load('exercicios/verificar_idades.html',function(){
            $('#verificar_idade').click(function(){
                var idades = $('#idades').val();
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
                $('#mostraIdades').html(menoresDeIdade + ' pessoas são menores de idade e ' + maioresDeIdade + ' pessoas são maiores de idade')
            })
        })
    })
})



