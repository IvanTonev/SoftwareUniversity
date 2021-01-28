function isMagic(matrix) {
    let rowsCount = matrix.length;
    let columnsCount = matrix[0].length;

    let firstRowSum = 0;
    for (let row = 0; row < rowsCount; row++) {
        let currentRowSum = 0;
        for (let col = 0; col < columnsCount; col++) {
            currentRowSum += matrix[row][col];
        }
        if (row == 0) {
            firstRowSum = currentRowSum;
        } else {
            if (firstRowSum != currentRowSum) {
                return false;
            }
        }
    }

    let firstColSum = 0;
    for (let col = 0; col < columnsCount; col++) {

        let currentColSum = 0;
        for (let row = 0; row < rowsCount; row++) {
            currentColSum += matrix[row][col];
        }
        if (col == 0) {
            firstColSum = currentColSum;
        } else {
            if (firstColSum != currentColSum) {
                return false;
            }
        }
    }

    return true;
}
