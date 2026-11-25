let I = 1
let J = 60
while (true){
    console.log(`I=${I} J=${J}`)
    I += 3
    J -= 5
    if(J < 0){
        break
    }
}