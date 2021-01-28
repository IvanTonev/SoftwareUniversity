function SortingNumbers(numbersArray) {
    numbersArray.sort(function (a, b) {
        return a - b;
    });
    let outputArray = [];
    let index = 0;
    while (numbersArray.length > 0) {
        if (index % 2 == 0) {
            outputArray.push(numbersArray.shift());
        } else {
            outputArray.push(numbersArray.pop());
        }
        index++;
    }

    return outputArray;
}
