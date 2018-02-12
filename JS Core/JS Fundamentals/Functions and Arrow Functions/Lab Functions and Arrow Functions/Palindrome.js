function palindrome(str) {

    let result = true

    for (let i = 0; i < str.length/2; i++) {
        if (str[i] != str[str.length - i - 1]){

            result = false
            break
        }
    }

    console.log(result)
}

palindrome('haha')
palindrome('racecar')