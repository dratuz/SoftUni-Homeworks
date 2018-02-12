// First Solution
/*function stringStartsWith(text, str) {

    let result = text.startsWith(str)

    if (result){
        console.log(true)
    }
    else {
        console.log(false)
    }
}*/

// Second Solution
function stringStartsWith(text, str){
    return text.startsWith(str)
}

console.log(stringStartsWith('How have you been?', 'how'))

console.log(stringStartsWith('Marketing Fundamentals, starting 19/10/2016', 'Marketing Fundamentals, sta'))