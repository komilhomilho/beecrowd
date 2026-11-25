import {lines} from '#input'

lines.shift()
let experimetos = {
    'C' : 0,
    'R' : 0,
    'S' : 0,
    "Total": 0,
    "Percentual_C": 0,
    "Percentual_R": 0,
    "Percentual_S": 0    
}

for(let item of lines){
    if (!item) {continue}
    let cobaias = item.split(" ")
    cobaias[1] = cobaias[1].trim().slice(0,1)
    experimetos.Total += parseInt(cobaias[0])
    experimetos[cobaias[1]] +=  parseInt(cobaias[0])
}

experimetos.Percentual_C = ((experimetos.C / experimetos.Total) * 100).toFixed(2)
experimetos.Percentual_R = ((experimetos.R / experimetos.Total) * 100).toFixed(2)
experimetos.Percentual_S = ((experimetos.S / experimetos.Total) * 100).toFixed(2)

console.log(`Total: ${experimetos.Total} cobaias`)
console.log(`Total de coelhos: ${experimetos.C}`)
console.log(`Total de ratos: ${experimetos.R}`)
console.log(`Total de sapos: ${experimetos.S}`)
console.log(`Percentual de coelhos: ${experimetos.Percentual_C} %`)
console.log(`Percentual de ratos: ${experimetos.Percentual_R} %`)
console.log(`Percentual de sapos: ${experimetos.Percentual_S} %`)


