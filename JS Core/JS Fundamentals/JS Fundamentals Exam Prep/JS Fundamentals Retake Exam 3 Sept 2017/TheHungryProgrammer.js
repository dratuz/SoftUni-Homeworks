function theHungryProgrammer(meals, commands) {

    let mealsEaten = 0

    for (let value of commands) {

        let command = value.split(' ')
        if (command[0] === 'End'){
            break
        }
        else if (command[0] === 'Serve' && meals.length >= 1){
            let item = meals.pop()
            console.log(`${item} served!`)
        }
        else if (command[0] === 'Add' && command.length === 2){
            let food = command[1]
            meals.unshift(food)
        }
        else if (command[0] === 'Shift' && command.length === 3){
            let firstIndex = command[1]
            let secondIndex = command[2]

            if (meals[firstIndex] !== undefined && meals[secondIndex] !== undefined){

                let m = meals[firstIndex]
                meals[firstIndex] = meals[secondIndex]
                meals[secondIndex] = m
            }
        }
        else if (command[0] === 'Eat' && meals.length >= 1){
            let meal = meals.shift()
            mealsEaten++

            console.log(`${meal} eaten`)
        }
        else if (
            command[0] === 'Consume' && command.length === 3 && meals.length >= 1  && meals.length >= Number(command[2])){

            let startIndex = Number(command[1])
            let endIndex = Number(command[2])

            let removed = meals.splice(startIndex, endIndex - startIndex + 1)
            mealsEaten += removed.length
            console.log('Burp!')
        }
    }

    if (meals.length > 0){
        console.log(`Meals left: ${meals.join(', ')}`)
    }
    else {
        console.log('The food is gone')
    }

    console.log(`Meals eaten: ${mealsEaten}`)
}





let input1 = [
    ['chicken', 'steak', 'eggs'],
    ['Serve', 'Eat', 'End', 'Consume 0 1']
]

let input2 = [
    ['fries', 'fish', 'beer', 'chicken', 'beer', 'eggs'],
    ['Add spaghetti', 'Shift 0 1', 'Consume 1 4', 'End']
]

let input3 = [
    ['carrots', 'apple', 'beet'],
    ['Consume 0 2', 'End',]
]

theHungryProgrammer(
    [],
    ['Serve',
        'Eat',
        'Consume 0 0',
        'Add chicken',
        'Add rice',
        'Eat',
        'End'])