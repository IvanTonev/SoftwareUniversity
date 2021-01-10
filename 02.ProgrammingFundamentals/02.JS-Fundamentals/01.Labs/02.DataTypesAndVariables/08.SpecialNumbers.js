function solve(number) {
    for (let i = 1; i <= number; i++) {
        let numberArray = i.toString().split('');
        let sum = 0;
        for (let n = 0; n < numberArray.length; n++) {
            sum += Number(numberArray[n]);
        }
        let isSpecial;
        if (sum == 5 || sum == 7 || sum == 11) {
            isSpecial = 'True';
        } else {
            isSpecial = 'False';
        }
        console.log(`${i} -> ${isSpecial}`);
    }
}
