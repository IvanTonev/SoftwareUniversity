function solve(number) {
    if (number < 0 || number > 7) {
        console.log('Invalid day!');
    } else {
        let days = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];
        console.log(days[number - 1]);
    }
}
