function calcular(){
    var total = document.getElementById('resp');
    var num1 = parseFloat(document.getElementById('num1').value);
    var num2 = parseFloat(document.getElementById('num2').value);
    switch (document.getElementById("oper").checked){
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
    document.getElementById("resp").innerHTML = total;
    return total;
}
