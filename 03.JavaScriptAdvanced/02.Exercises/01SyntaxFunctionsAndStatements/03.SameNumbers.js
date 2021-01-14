function sameNumbers(input) {
    let number = input % 10;
    let sum = number;
    input =  input / 10 ^ 0;
    let sameNumbers = true;
    while (input > 0) {
        if (number != input % 10){
            sameNumbers = false;
        }
        number = input % 10;
        sum += number;
        input =  input / 10 ^ 0;
    }
    console.log(sameNumbers);
    console.log(sum);
}
