function stringEndsWith(text, str) {
    return text.endsWith(str)
}

console.log(stringEndsWith('This sentence ends with fun?', 'fun?'))

console.log(stringEndsWith('This is Houston, we have…', 'We have…'))