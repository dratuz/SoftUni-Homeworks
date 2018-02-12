function fromJSONToHTMLTable(input) {
    let html = "<table>\n"

    let arr = JSON.parse(input)
    
    html += "   <tr>"
    for (let obj of Object.keys(arr[0])) {
        html += `<th>${replaceSymbols(obj)}</th>`
    }
    html += "</tr>\n"

    for (let obj of arr) {
        html += "   <tr>"
        let objValues = Object.values(obj)

        for (let value of objValues) {
            html += `<td>${replaceSymbols(value.toString())}</td>`
        }
        html += "</tr>\n"
    }

    console.log(html + "</table>")
    
    function replaceSymbols(str) {
        return str.replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;')
    }
}

fromJSONToHTMLTable('[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]')