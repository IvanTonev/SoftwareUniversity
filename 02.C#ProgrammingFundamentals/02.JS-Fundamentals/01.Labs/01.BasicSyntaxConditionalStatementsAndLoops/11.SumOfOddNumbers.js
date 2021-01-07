function solve(n) {
    sum = 0;
    for (i = 1; i <= 2*n; i += 2) {
        console.log(i);
        sum += i;
    }
    console.log('Sum: ' + sum);
}
