function circleArea(r) {

    let area = Math.PI * r * r
    let roundArea = Math.round(area * 100) / 100

    console.log(area)
    console.log(roundArea)
}

circleArea(5)