function countWordsInText(input) {

    let result = {}
    let reg = new RegExp(/\W+/, 'g')
    let arr = input[0].replace(reg, ' ').trim().split(' ')

    for (let obj of arr) {
        if (!result.hasOwnProperty(obj)){
            result[obj] = 1
        }
        else {
            result[obj] += 1
        }
    }

    console.log(JSON.stringify(result))
}

countWordsInText(['Far too slow, you\'re far too slow.'])