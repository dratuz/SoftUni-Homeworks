function distanceOverTime(input) {

    let object1Distance = (input[0] / 3.6) * input[2]
    let object2Distance = (input[1] / 3.6) * input[2]

    let result = Math.abs(object1Distance - object2Distance)

    console.log(result)
}

distanceOverTime([0, 60, 3600])