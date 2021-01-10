function reverse(elements) {
    for (let i = 0; i < elements.length / 2; i++) {
        swapElements(elements, i, elements.length - 1 - i) 
    }
    function swapElements(arr, i, j) {
        let temp = arr[i];
        arr[i] = elements[j];
        arr[j] = temp;
    }
    console.log(elements.join(' '));
}
