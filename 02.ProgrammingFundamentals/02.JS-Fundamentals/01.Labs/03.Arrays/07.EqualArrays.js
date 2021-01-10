function equalArrays(firstArr, secondArr) {
    let areEquals = true;
    let index;
    for (let i = 0; i <= firstArr.length; i++) {
        if (firstArr[i] != secondArr[i]) {
            areEquals = false;
            index = i;
            break;
        }
    }
    if (areEquals) {
        let sum = 0;
        for (let number of firstArr) {
            sum += Number(number);
        }
        console.log(`Arrays are identical. Sum: ${sum}`)
    } else {
        console.log(`Arrays are not identical. Found difference at ${index} index`)
    }
}
