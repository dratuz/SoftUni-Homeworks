function nowPlayng(input) {

    let trackName = input[0]
    let artistName = input[1]
    let trackDuration = input[2]

    console.log(`Now Playing: ${artistName} - ${trackName} [${trackDuration}]`)
}

nowPlayng(['Number One', 'Nelly', '4:09'])