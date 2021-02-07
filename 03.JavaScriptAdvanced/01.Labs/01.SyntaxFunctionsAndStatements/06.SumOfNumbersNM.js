function solve(n, m) {
    let firstNumber = Number(n);
    let secondNumber = Number(m);
    let sum = 0;
    for (i = firstNumber; i <= secondNumber; i++) {
        sum += i;
    }
    return sum;
}
