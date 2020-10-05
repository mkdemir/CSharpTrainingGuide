var sayi1 = 10 // Değer atama
var sayi2 = 10
var sayi3 = 20
// Değer atama bide referans atama diye bir şey var.
if (sayi1 == sayi2 && sayi1 == sayi3) { // sayi1 == sayi2 == sayi3 diye bir kullanım yok. (Burada 2 tane koşul şart koşuluyor.)
    console.log('Eşit.')
}

if (sayi1 == sayi2 || sayi1 == sayi3) { // sayi1 == sayi2 == sayi3 diye bir kullanım yok. (or)
    console.log('Eşit.')
}

// || altgr + > -> pipe deniyor boru anlamı var.