function lastMonth(input) {

    let day = input[0]
    let month = input[1]
    let year = input[2]

    let date = new Date(year, month - 1, 0)

    console.log(date.getDate())
}

lastMonth([17, 3, 2002])