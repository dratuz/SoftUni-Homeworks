//First Solution
/*function processOddNumbers(input) {

    let result = []

    for (let i = 0; i < input.length; i++) {
        if (i % 2 !== 0){
            let num = input[i] * 2
            result.unshift(num)
        }
    }

    console.log(result.join(' '))
}*/

//Second Solution
function processOddNumbers(input){
    let result = input
        .filter((num, i) => i % 2 == 1)
        .map(x => 2 * x)
        .reverse()

    console.log(result.join(' '))
}

processOddNumbers([10, 15, 20, 25])