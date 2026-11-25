import {lines} from '#input'

let n = parseInt(lines.shift())
let resul = 1
while(n >= 1){
    resul *= n
    n--
}
console.log(resul)