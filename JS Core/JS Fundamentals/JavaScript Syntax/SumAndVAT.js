function sumVAT(input) {
    let sum  = 0;
    
    for (let num of input) {
        sum += num
    }

    let vat = sum * 0.20
    let total = sum * 1.20

    console.log("sum = " + sum)
    console.log("VAT = " + vat)
    console.log("sum = " + total)
}