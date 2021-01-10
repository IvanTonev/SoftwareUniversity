function solve(number) {
    let numberArray = number.toString().split('');
    let sum = 0;
    for (i = 0; i < numberArray.length; i++) {
        sum += Number(numberArray[i]);
    }
    let isAmazing;
    if (sum.toString().includes('9')) {
        isAmazing = 'True';
    } else {
        isAmazing = 'False';
    }
    console.log(`${number} Amazing? ${isAmazing}`)
}
