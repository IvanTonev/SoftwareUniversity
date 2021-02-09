function aggregateElements(elementsArray) {
    let sum = 0;
    let inverseSum = 0;
    let concat = '';
    for (i = 0; i < elementsArray.length; i++) {
        sum += elementsArray[i];
        inverseSum += 1 / elementsArray[i];
        concat += elementsArray[i];
    }
    console.log(sum);
    console.log(inverseSum);
    console.log(concat);
}
