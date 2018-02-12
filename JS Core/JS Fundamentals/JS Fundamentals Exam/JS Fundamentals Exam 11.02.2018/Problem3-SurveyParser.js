function surveyParser(input) {
    let svgRe = new RegExp(/<svg>[\S\s]*?<\/svg>/, 'g')
    let catRe = new RegExp(/<cat>[\S\s]*?<\/cat>/, 'g')
    let textRe = new RegExp(/<text>[\S\s]*?<\/text>/, 'g')
    let gRe = new RegExp(/<g>[\S\s]*?<\/g>/, 'g')
    let valRe = new RegExp(/<val>\d+<\/val>/, 'g')

    let textValueRe = new RegExp(/\[[\w\W]*?\]/, 'g')

    let svgResult = svgRe.exec(input)
    let catResult = catRe.exec(svgResult)

    let textResult = textRe.exec(catResult)
    let textValueResult = textValueRe.exec(textResult)

    let gResult = gRe.exec(catResult)
    let valResult = valRe.exec(gResult)

    while (textValueResult.length > 0){
        let result = textValueResult.slice(1, textValueResult.length - 1)

        console.log(result)
    }
}

surveyParser(['<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>'])