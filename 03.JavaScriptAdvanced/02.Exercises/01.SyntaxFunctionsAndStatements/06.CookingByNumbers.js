function cookingByNumbers(numberString, operatorFirst, operatorSecond, operatorThird, operatorFourth, operatorFifth) {
    let number = Number(numberString);
    number = operation(operatorFirst, number);
    console.log(number);
    number = operation(operatorSecond, number);
    console.log(number);
    number = operation(operatorThird, number);
    console.log(number);
    number = operation(operatorFourth, number);
    console.log(number);
    number = operation(operatorFifth, number);
    console.log(number);

    function operation(operator, number,) {
        switch (operator) {
            case 'chop':
                return number / 2;
            case 'dice':
                return Math.sqrt(number);
            case 'spice':
                return number + 1;
            case 'bake':
                return 3 * number;
            case 'fillet':
                return number - (0.2 * number);
        }
    }
}
