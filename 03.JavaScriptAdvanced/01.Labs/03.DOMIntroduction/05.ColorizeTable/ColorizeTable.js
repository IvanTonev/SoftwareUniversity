function colorize() {
    const trs = document.getElementsByTagName('tr');
    for (let i = 1; i < trs.length; i++) {
        if (i % 2 == 1) {
            trs[i].style.backgroundColor = 'Teal';
        }
    }
}
