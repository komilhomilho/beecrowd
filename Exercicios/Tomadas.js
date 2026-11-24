import { lines } from "#input";

const tomadas = lines.shift().split(" ").map(Number)
let NumeroMaximoAparelhos = 0;
tomadas.forEach( x => {
    NumeroMaximoAparelhos += x
});
NumeroMaximoAparelhos -= 3
console.log(NumeroMaximoAparelhos)