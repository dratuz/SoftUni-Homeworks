function jsonTable(input) {

    for (let i = 0; i < input.length; i++) {
        input[i] = JSON.parse(input[i])
    }

    html = "<table>"

    for (let obj of input) {
        let value = Object.values(obj)

        html += '\n\t<tr>'
        html += `\n\t\t<td>${value[0]}</td>`
        html += `\n\t\t<td>${value[1]}</td>`
        html += `\n\t\t<td>${Number(value[2])}</td>`
        html += '\n\t<tr>'
    }
    html += "\n</table>"

    console.log(html)
}

jsonTable(
    ['{"name":"Pesho","position":"Promenliva","salary":100000}',
    '{"name":"Teo","position":"Lecturer","salary":1000}',
    '{"name":"Georgi","position":"Lecturer","salary":1000}'])