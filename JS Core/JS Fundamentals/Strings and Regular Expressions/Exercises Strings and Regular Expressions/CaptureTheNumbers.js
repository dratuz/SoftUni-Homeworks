function captureTheNumbers(text) {

    let reg = new RegExp(/\d+/, 'g')
    let result = []
    let match

    while (match = reg.exec(text)){
        result.push(match)
    }

    console.log(result.join(' '))
}

captureTheNumbers('The300\n' +
    'What is that?\n' +
    'I think it’s the 3rd movie.\n' +
    'Lets watch it at 22:45')