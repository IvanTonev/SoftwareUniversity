function solve(input) {
    let incorrectPasswordCount = 0;
    let username = input[0];
    let password = username.split('').reverse().join('');
    for (i = 1; i < input.length; i++) {
        let receivedPassword = input[i];
        if (password === receivedPassword) {
            console.log(`User ${username} logged in.`);
            return;
        } else {
            console.log(`Incorrect password. Try again.`);
            incorrectPasswordCount++;
        }
        if (incorrectPasswordCount == 3){
            console.log(`User ${username} blocked!`);
           return;
        }
    }
}
