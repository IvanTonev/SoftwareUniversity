function rotateArray(stringArray, number) {
    for (let i = 0; i < number; i++) {
        stringArray.unshift(stringArray.pop());
    }
    console.log(stringArray.join(' '));
}
