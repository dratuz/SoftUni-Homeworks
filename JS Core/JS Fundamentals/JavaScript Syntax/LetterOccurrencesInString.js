function letterOccurencesInString(word, letter) {

    let count = 0

    for (let index = 0; index < word.length; index++) {
        if (word[index] === letter) {
            count++
        }
    }

    console.log(count)
}