function extractText() {
    let result = ('#result');

    let list = $('ul#items li')
        .toArray()
        .map(li => li.textContent)
        .join(', ');

    $(result).text(list);
}