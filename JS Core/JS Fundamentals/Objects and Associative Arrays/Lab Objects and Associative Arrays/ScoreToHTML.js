function scoreToHTML(input) {
    console.log('<table>')
    console.log('<tr><th>name</th><th>score</th></tr>')

    let arr = JSON.parse(input)

    for (let obj of arr) {
        let element = Object.values(obj)

        console.log(`<tr><td>${replaceSymbols(element[0])}</td><td>${element[1]}</td></tr>`)
    }

    console.log('</table>')

    function replaceSymbols(str) {
        return str.replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;')
    }
}

scoreToHTML('[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]')