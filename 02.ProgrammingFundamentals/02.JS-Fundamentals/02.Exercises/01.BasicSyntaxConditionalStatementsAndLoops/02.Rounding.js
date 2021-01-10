function solve(number, precision) {
    if (precision > 15){
        precision = 15;
    }

    console.log(parseFloat(number.toFixed(precision)));
}
