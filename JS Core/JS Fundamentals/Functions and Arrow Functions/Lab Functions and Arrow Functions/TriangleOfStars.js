function triangleOfStars(num) {

    for (let i = 0; i < num; i++) {
        console.log("*".repeat(i))
    }
    for (let i = num; i >= 1; i--) {
        console.log("*".repeat(i))
    }
}

triangleOfStars(5)