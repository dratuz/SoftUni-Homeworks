function bitcoinMining(days){

    //let str = input.toString()
    //let days = str.split(', ')

    let lvPerGold = 67.51
    let lvPerBitcoin = 11949.16

    let money = 0
    let firstDayToPerches = 0

    if (days.length <= 1000){
        for (let i = 0; i < days.length; i++) {
            if (Number(days[i]) <= 0 || Number(days[i]) > 5000){
                continue
            }
            else {
                if ((i + 1) % 3 !== 0){
                    money += Number(days[i]) * lvPerGold
                    if (money >= lvPerBitcoin){
                        if (firstDayToPerches === 0){
                            firstDayToPerches = i + 1
                        }
                    }
                }
                else {
                    money += Number(days[i]) * (lvPerGold * 0.7)
                    if (money >= lvPerBitcoin){
                        if (firstDayToPerches === 0){
                            firstDayToPerches = i
                        }
                    }
                }
            }
        }
    }

    let bitcoin = Math.floor(money / lvPerBitcoin)
    money = money - (lvPerBitcoin * bitcoin)

    console.log(`Bought bitcoins: ${bitcoin}`)
    if (firstDayToPerches > 0){
        console.log(`Day of the first purchased bitcoin: ${firstDayToPerches}`)
    }
    console.log(`Left money: ${money.toFixed(2)} lv.`)
}

bitcoinMining([[5005], [-100]])
