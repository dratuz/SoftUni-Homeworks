function stringOfNumbers(input) {
    let strNum = ''

    for (let num = 1; num <= input; num++) {
        
        strNum += num
    }

    console.log(strNum)
}

stringOfNumbers('11')