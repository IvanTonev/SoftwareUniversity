function solve(start, end) {
    let numbers = [];
    let sum = 0;
    for (i = start; i <= end; i++){
        numbers.push(i);
        sum += i;
    }
    console.log(numbers.join(' '));
    console.log(`Sum: ${sum}`);
}
