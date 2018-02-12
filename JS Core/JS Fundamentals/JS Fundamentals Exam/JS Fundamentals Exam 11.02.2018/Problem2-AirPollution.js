function airPollution(inputMatrix, input) {

    let matrix = []
    let result = []

    if (inputMatrix.length === 5){

        for (let i = 0; i < inputMatrix.length; i++) {
            let rowLength = inputMatrix[i].split(' ')
            if (rowLength.length === 5){
                let num = inputMatrix[i].split(' ').map(Number)
                if (num > 1000 || num < 0){
                    return
                }

                matrix.push(num)
            }
            else {
                return
            }
        }
    }
    else {
        return
    }

    if (input.length > 100 || input.length < 0){
        return
    }
    for (let i = 0; i < input.length; i++) {
        let value = input[i].split(' ')
        if (value[0] === 'breeze'){
            for (let row = 0; row < matrix.length; row++) {
                for (let col = 0; col < matrix[row].length; col++) {
                    if (row === Number(value[1])){
                        matrix[row][col] = Number(matrix[row][col]) - 15
                    }
                }
            }
        }
        else if (value[0] === 'gale'){
            for (let row = 0; row < matrix.length; row++) {
                for (let col = 0; col < matrix[row].length; col++) {
                    if (col === Number(value[1])){
                        matrix[row][col] = Number(matrix[row][col]) - 20
                    }
                }
            }
        }
        else if (value[0] === 'smog'){
            if (value[1] > 100 || value[1] < 0){
                return
            }
            for (let row = 0; row < matrix.length; row++) {
                for (let col = 0; col < matrix[row].length; col++) {
                    matrix[row][col] = Number(matrix[row][col]) + Number(value[1])
                }
            }
        }
    }

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (matrix[row][col] < 0){
                matrix[row][col] = 0
            }
            if (matrix[row][col] >= 50){
                result.push(`[${row}-${col}]`)
            }
        }
    }


    //for (let obj of matrix) {
    //    console.log(obj)
    //}

    if (result.length > 0){

        console.log(`Polluted areas: ${result.join(', ')}`)
    }
    else {

        console.log('No polluted areas')
    }
}

airPollution([
        "5 7 72 14 4 4",
        "41 35 37 27 33",
        "23 16 27 42 12",
        "2 20 28 39 14",
        "16 34 31 10 24",
    ],
    ["breeze 1", "gale 2", "smog 25"])


airPollution([
        "5 7 3 28 32",
        "41 12 49 30 33",
        "3 16 20 42 12",
        "2 20 10 39 14",
        "7 34 4 27 24",
    ],
    [
        "smog 11", "gale 3",
        "breeze 1", "smog 2"
    ])

airPollution([
        "5 7 2 14 4",
        "21 14 2 5 3",
        "3 16 7 42 12",
        "2 20 8 39 14",
        "7 34 1 10 24",
    ],
    ["breeze 1", "gale 2", "smog 35"])