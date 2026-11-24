import {input, lines} from "#input"

const correto = Number(lines.shift())
let contagem = 0
lines.shift().split(" ").map(Number).forEach(x => {
    if (x == correto){
        contagem++
    }
})

console.log(contagem)