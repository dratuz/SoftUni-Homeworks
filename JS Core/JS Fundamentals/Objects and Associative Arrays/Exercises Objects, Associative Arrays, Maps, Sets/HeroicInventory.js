function heroicInventory(input) {

    let result = []
    let re = new RegExp(/ \/ /, 'g')

    for (let obj of input) {

        let heroInfo = obj.split(re)

        let heroName = heroInfo[0]
        let heroLv = Number(heroInfo[1])

        let heroItems = []
        if (heroInfo.length > 2){
            heroItems = heroInfo[2].split(', ')
        }

        let hero = {
            name: heroName,
            level: heroLv,
            items: heroItems
        }

        result.push(hero)
    }

    console.log(JSON.stringify(result))
}

heroicInventory(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara]'])



