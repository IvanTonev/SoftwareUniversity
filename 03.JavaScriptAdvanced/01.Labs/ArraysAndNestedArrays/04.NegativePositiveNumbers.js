function solve(input) {
    let output = [];
    for (i = 0; i < input.length; i++) {
        if (input[i] < 0) {
            output.unshift(input[i]);
        } else {
            output.push(input[i]);
        }
    }
    for (i = 0; i < output.length; i++) {
        console.log(output[i]);
    }
}
