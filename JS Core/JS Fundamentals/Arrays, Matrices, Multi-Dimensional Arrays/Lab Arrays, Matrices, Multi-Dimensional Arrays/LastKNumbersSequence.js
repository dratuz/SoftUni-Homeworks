function lastKNumbersSequence(n, k) {
    let result = [1]

    for (let current = 1; current < n; current++) {
        let start = Math.max(0, current - k)
        let end = current + 1

        result[current] = result.slice(start, end)
            .reduce((a, b) => a + b)
    }

    console.log(result.join(' '))
}

lastKNumbersSequence(6, 3)