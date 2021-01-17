function solve(input) {
    let outputArray = [];
    for (i = 0; i < input.length; i += 2) {
        outputArray.push(input[i]);
    }
    let output = outputArray.join(' ');
    console.log(output)
}
