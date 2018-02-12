function concatenateReversed(words) {

    let result = ''

    for (let i = 0; i < words.length; i++) {
        result += words[i]
    }

    console.log(result.split("").reverse().join(""))
}

concatenateReversed(['I', 'am', 'student'])