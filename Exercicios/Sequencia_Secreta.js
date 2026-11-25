import {lines} from "#input"

let i = parseInt(lines.shift())
let anterior = 0
let resultado = 0
for(i >= 0; i--;){
    if(anterior != lines[i]){
        anterior = lines[i]
        resultado++
    }
}

console.log(resultado)
