function splitStringWithDelimiter(text, delimiter) {

    let result = text.split(delimiter)

    console.log(result.join('\n'))
}

splitStringWithDelimiter('One-Two-Three-Four-Five', '-')

splitStringWithDelimiter('http://platform.softuni.bg', '.')