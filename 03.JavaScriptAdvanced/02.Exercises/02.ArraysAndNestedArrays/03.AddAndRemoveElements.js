function addAndRemoveElements(commandsArray) {
    let outputArray = [];
    for (let i = 0; i < commandsArray.length; i++) {
        let command = commandsArray[i];
        if (command == 'add') {
            outputArray.push(i + 1);
        } else if (command == 'remove') {
            outputArray.pop();
        }
    }
    if (outputArray.length > 0) {
        for (let i = 0; i < outputArray.length; i++) {
            console.log(outputArray[i]);
        }
    } else {
        console.log('Empty');
    }
}
