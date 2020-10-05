var sayi1 = 291
var sayi2 = 30
var sayi3 = 2

// En büyük sayıyı bulunuz.

// if(sayi1>sayi2){
//     if(sayi1>sayi3){
//         console.log('En büyük sayi1\'dir.')
//     }
// }
// if(sayi2>sayi1){
//     if(sayi2>sayi3){
//         console.log('En büyük sayi2\'dir.')
//     }
// }
// if(sayi3>sayi1){
//     if(sayi3>sayi2){
//         console.log('En büyük sayi3\'dir.')
//     }
// }

//js'de noktalı virgülün olup olmamasının hiçbir anlamı yoktur.
var enBuyuk = sayi1

if (enBuyuk < sayi2) {
    enBuyuk = sayi2;
}
if (enBuyuk < sayi3) {
    enBuyuk = sayi3;
}
console.log("Bu sayıların içinde en büyük = " + enBuyuk)