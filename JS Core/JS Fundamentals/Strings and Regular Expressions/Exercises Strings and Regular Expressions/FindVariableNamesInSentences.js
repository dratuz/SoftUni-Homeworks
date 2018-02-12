function findVariableNamesInSentences(text) {

    let reg = new RegExp(/\b_[A-Za-z0-9]+\b/, 'g')
    let result = []
    let match

    while (match = reg.exec(text)){

        result.push(match[0].substring(1))
    }

    console.log(result.join(','))
}

findVariableNamesInSentences('Calculate the _area of the _perfectRectangle object.')