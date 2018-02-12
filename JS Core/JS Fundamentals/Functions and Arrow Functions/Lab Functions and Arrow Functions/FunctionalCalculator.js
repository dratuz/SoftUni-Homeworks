function functionalCalculator(num1, num2, operator) {

    switch(operator) {
        case '+':
            console.log(num1 + num2)
            break
        case '-':
            console.log(num1 - num2)
            break
        case '*':
            console.log(num1 * num2)
            break
        case '/':
            console.log(num1 / num2)
            break
    }
}

functionalCalculator(2, 4, '+')
functionalCalculator(3, 3, '/')
functionalCalculator(18, -1, '*')