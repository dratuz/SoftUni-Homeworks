function rounding(input) {

    let numToBeRounded = input[0]
    let precision = input[1]

    if (precision > 15){
        precision = 15
    }

    console.log(parseFloat(numToBeRounded.toFixed(precision)))
}

rounding([3.1415926535897932384626433832795, 2])