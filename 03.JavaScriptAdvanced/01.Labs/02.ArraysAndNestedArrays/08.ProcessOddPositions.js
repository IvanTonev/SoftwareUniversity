function solve(input) {
    let oddPositionsInput = [];
    let output = [];
    for (i = 1; i < input.length; i += 2) {
        oddPositionsInput.push(input[i]);
    }
    let reversedArray = oddPositionsInput.reverse();
    for (i = 0; i < reversedArray.length; i++) {
        output.push(2 * reversedArray[i])
    }
    return output;
}
