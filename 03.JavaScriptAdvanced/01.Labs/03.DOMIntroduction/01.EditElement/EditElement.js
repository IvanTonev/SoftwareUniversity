function editElement(reference, match, replacer) {
    const matcher = new RegExp(match, 'g');
    const result = reference.textContent.replace(matcher, replacer);
    reference.textContent = result;
    console.log(reference.textContent);
}
