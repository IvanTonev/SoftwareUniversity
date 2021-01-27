function printEveryNthElementFromAnArray(stringArray, number) {
    let outputArray = [];
    for (let i = 0; i < stringArray.length; i += number) {
        outputArray.push(stringArray[i]);
    }

    return outputArray;
}
