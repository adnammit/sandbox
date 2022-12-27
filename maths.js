
// return factorial of num
function FirstFactorial(num) {

    var total = 1;
    for ( ; num > 0; num--) {
        total*=num;
    }
    return total;
}

// return factorial of num recursively
function FirstFactorialTwo(num) {
    return (num > 1) ? FirstFactorialTwo(num - 1) * num : 1;
}

FirstFactorial(4); //24
FirstFactorialTwo(4); //24
