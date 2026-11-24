import {lines} from "#input"

lines.shift()
let anterior = lines.shift()
let resultado = 0
lines.forEach(x =>{
    if(anterior != x){
        anterior = x;
        resultado++;
    }
}) 

console.log(resultado)