function solve(firstNumber, secondNumber, thirdNumber) {
    let sum = firstNumber + secondNumber + thirdNumber;
    let type;
    if (sum % 1 == 0) {
        type = 'Integer';
    }
    else {
        type = 'Float';
    }
    console.log(`${sum} - ${type}`)
}
