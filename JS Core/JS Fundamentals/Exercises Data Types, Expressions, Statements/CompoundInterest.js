function compoundInterest(input) {

    let p = input[0]
    let i = input[1]
    let n = 12 / input[2]
    let t = input[3]

    let nt = n * t
    let result = p * Math.pow((1 + i / (100 * n)), nt)

    console.log(result.toFixed(2))
}

compoundInterest([1500, 4.3, 3, 6])