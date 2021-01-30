function extractText() {
    let items = document.getElementById('items').getElementsByTagName('li');
    console.log(items[0]);
    for (i = 0; i < items.length; i++) {
        document.getElementById('result').textContent += items[i].textContent + '\n';
    }
}
