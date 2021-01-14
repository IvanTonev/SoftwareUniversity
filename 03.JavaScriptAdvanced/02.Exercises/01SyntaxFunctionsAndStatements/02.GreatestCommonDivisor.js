function greatestCommonDivisor(firstNumber, secondNumber) {
    let minNumber = firstNumber < secondNumber ? firstNumber : secondNumber;
    for (i = minNumber; i >= 1; i--) {
        if (firstNumber % i == 0 && secondNumber % i == 0) {
            console.log(i);
            break;
        }
    }
}
