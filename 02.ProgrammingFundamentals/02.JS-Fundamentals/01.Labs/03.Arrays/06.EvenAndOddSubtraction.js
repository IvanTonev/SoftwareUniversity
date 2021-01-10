function substractionEvenAndOdd(arr) {
    let evenSum = 0;
    let oddSum = 0;
    for (i = 0; i < arr.length; i++) {
        let number = Number(arr[i]);
        if (number % 2 == 0) {
            evenSum += number;
        } else {
            oddSum += number;
        }
    }
    console.log(evenSum - oddSum);
}
