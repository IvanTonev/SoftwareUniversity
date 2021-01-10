function solve(firstString, missingChar, secondString) {
    let replacedString = firstString.replace('_', missingChar);
    if (replacedString == secondString) {
        console.log('Matched');
    } else {
        console.log('Not Matched');
    }
}
