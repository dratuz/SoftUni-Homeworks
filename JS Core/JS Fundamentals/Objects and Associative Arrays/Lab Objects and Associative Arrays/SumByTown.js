function sumByTown(input) {

    let result = {}

    for (let i = 0; i < input.length; i+=2) {

        let [town, income] = [input[i], Number(input[i+1])]

        if (result[town] == undefined){
            result[town] = income
        }
        else {
            result[town] += income
        }
    }

    console.log(JSON.stringify(result))
}

sumByTown(['Sofia', '20', 'Varna', '3', 'Sofia', '5', 'Varna', '4'])