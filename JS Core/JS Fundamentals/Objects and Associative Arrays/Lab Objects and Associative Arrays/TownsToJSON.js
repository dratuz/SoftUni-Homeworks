function townsToJSON(input) {

    let reg = new RegExp(/\s*\|\s*/, 'g')

    let towns = []

    for (let value of input.slice(1)) {

        let info = value.split(reg)
        let town = {Town: info[1], Latitude: Number(info[2]), Longitude: Number(info[3])}

        towns.push(town)
    }

    console.log(JSON.stringify(towns))
}

townsToJSON(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |'])