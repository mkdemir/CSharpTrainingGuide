/**
 * Döngüler -> Birbirine benzeyen işlemleri arka arkaya istediğimiz sayıda veya belli bir şarta göre çalıştırıp tekrarlamaya yarayan yapılardır.
 */

var sayi = 10

// while(sayi<=10){ // while -> iken demek yani sayi küçük eşittir 10 iken (infinite loop sonsuz döngğ)
// console.log(sayi)
// }
// Buna sonzu döngü denir

sayi = 1
while(sayi<= 10){
    console.log(sayi)
    sayi = sayi + 1 
}
sayi = 2
while(sayi<=100){
    console.log(sayi)
    sayi = sayi + 2
}

sayi = 1
while(sayi<=100){
    console.log(sayi)
    sayi = sayi + 2
}
