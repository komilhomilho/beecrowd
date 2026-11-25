let I = 1
let J = 7
let cont = 0
while (cont >= 0) {
    console.log(`I=${I} J=${J}`)
    J -= 1
    cont++
    if (cont % 3 == 0) {
        I += 2;
        J += 5
    }
    if (I > 9) {
        break
    }
}