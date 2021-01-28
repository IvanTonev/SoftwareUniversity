function playTicTacToe(movesArray) {
    let dashboard =
        [[false, false, false],
        [false, false, false],
        [false, false, false]];

    let player = "X"
    let hasWinner = false;
    for (let turn = 0; turn < movesArray.length; turn++) {
        let currnetMove = movesArray[turn];

        let cordinatesArray = currnetMove.split(' ');
        let row = cordinatesArray[0];
        let col = cordinatesArray[1];
        if (dashboard[row][col] != false) {
            console.log('This place is already taken. Please choose another!');
        } else {
            dashboard[row][col] = player;

            if (player == 'X') {
                if (winnerCheckX()) {
                    console.log('Player X wins!');
                    hasWinner = true;
                    break;
                }
                player = 'O'
            } else {
                if (winnerCheckO()) {
                    console.log('Player O wins!');
                    hasWinner = true;
                    break;
                }
                player = 'X'
            }

            if (!hasFreeSpaces()) {
                break;
            }
        }
    }
    if (!hasWinner) {
        console.log('The game ended! Nobody wins :(')
    }
    for (let row = 0; row < dashboard.length; row++) {
        console.log(dashboard[row].join('\t'));
    }

    function hasFreeSpaces() {
        if (dashboard[0][0] != false && dashboard[0][1] != false && dashboard[0][2] != false &&
            dashboard[1][0] != false && dashboard[1][1] != false && dashboard[1][2] != false &&
            dashboard[2][0] != false && dashboard[2][1] != false && dashboard[2][2] != false) {
            return false;
        } else {
            return true;
        }
    }

    function winnerCheckX() {
        if (dashboard[0][0] == dashboard[0][1] && dashboard[0][1] == dashboard[0][2] && dashboard[0][0] == 'X' ||
            dashboard[1][0] == dashboard[1][1] && dashboard[1][1] == dashboard[1][2] && dashboard[1][0] == 'X' ||
            dashboard[2][0] == dashboard[2][1] && dashboard[2][1] == dashboard[2][2] && dashboard[2][0] == 'X') {
            return true;
        } else if (dashboard[0][0] == dashboard[1][0] && dashboard[1][0] == dashboard[2][0] && dashboard[0][0] == 'X' ||
            dashboard[0][1] == dashboard[1][1] && dashboard[1][1] == dashboard[2][1] && dashboard[0][1] == 'X' ||
            dashboard[0][2] == dashboard[1][2] && dashboard[1][2] == dashboard[2][2] && dashboard[0][2] == 'X') {
            return true;
        }
        else if (dashboard[0][0] == dashboard[1][1] && dashboard[1][1] == dashboard[2][2] && dashboard[0][0] == 'X' ||
            dashboard[0][2] == dashboard[1][1] && dashboard[1][1] == dashboard[2][0] && dashboard[0][2] == 'X') {
            return true;
        }

        return false;
    }

    function winnerCheckO() {
        if (dashboard[0][0] == dashboard[0][1] && dashboard[0][1] == dashboard[0][2] && dashboard[0][0] == 'O' ||
            dashboard[1][0] == dashboard[1][1] && dashboard[1][1] == dashboard[1][2] && dashboard[1][0] == 'O' ||
            dashboard[2][0] == dashboard[2][1] && dashboard[2][1] == dashboard[2][2] && dashboard[2][0] == 'O') {
            return true;
        } else if (dashboard[0][0] == dashboard[1][0] && dashboard[1][0] == dashboard[2][0] && dashboard[0][0] == 'O' ||
            dashboard[0][1] == dashboard[1][1] && dashboard[1][1] == dashboard[2][1] && dashboard[0][1] == 'O' ||
            dashboard[0][2] == dashboard[1][2] && dashboard[1][2] == dashboard[2][2] && dashboard[0][2] == 'O') {
            return true;
        }
        else if (dashboard[0][0] == dashboard[1][1] && dashboard[1][1] == dashboard[2][2] && dashboard[0][0] == 'O' ||
            dashboard[0][2] == dashboard[1][1] && dashboard[1][1] == dashboard[2][0] && dashboard[0][2] == 'O') {
            return true;
        }

        return false;
    }
}
