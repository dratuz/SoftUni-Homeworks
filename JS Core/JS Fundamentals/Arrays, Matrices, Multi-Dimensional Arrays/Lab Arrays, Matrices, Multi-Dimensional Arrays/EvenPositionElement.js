//First Solution
/*function evenPositionElement(input) {

    let result = []

    for (let i = 0; i < input.length; i++) {
        if (i % 2 == 0){
            result.push(input[i])
        }
    }

    console.log(result.join(' '))
}*/

//Second Solution
function evenPositionElement(input) {

    let result = []
    let position = 0

    for (let element of input) {
        if (position % 2 == 0){
            result.push(element)
        }
        position++
    }

    console.log(result.join(' '))
}

evenPositionElement(['20', '30', '40'])