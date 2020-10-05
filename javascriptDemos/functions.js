/* Ornek 1.

// Sayılsal Loto 1'den 49 kadar 6 tane sayı söyleyip onu tuturmaya çalıştırma.

var sayi1 = 6
var sayi2 = 16
var sayi3 = 3
var sayi4 = 48
var sayi5 = 49
var sayi6 = 11

// console.log() ile ekrana yazı yazdırıyoruz.
console.log('Kolon: ' + sayi1 + ' ' + sayi2 + ' ' + sayi3 + ' ' + sayi4 + ' ' + sayi5 + ' ' + sayi6 + ' ')


 */


/* Ornek2.

// Math.ceil() -> Hazır bir fonksiyondur üretilen bir sayıyı yukarıya yuvarlıyor.
var sayi1 = Math.ceil(Math.random() * 49)// Hazır bir fonkisyon var random bir sayı üretmek için bir tane fonksiyonumuz var. 0 ile 1 arasında sayı üretmeye yarıyor. Hiçbir zaman 1 üretmiyor. Birden küçük bir sayı üretiyor. Bunu yukarıya doğru yuvarlamak gerekiyor ondalıkta vermesin diye
var sayi2 = Math.ceil(Math.random() * 49)
var sayi3 = Math.ceil(Math.random() * 49)
var sayi4 = Math.ceil(Math.random() * 49)
var sayi5 = Math.ceil(Math.random() * 49)
var sayi6 = Math.ceil(Math.random() * 49)
// Hiç bir fonksiyon yazmadan hazır bir fonksiyon yazdık.
console.log('Kolon: ' + sayi1 + ' ' + sayi2 + ' ' + sayi3 + ' ' + sayi4 + ' ' + sayi5 + ' ' + sayi6 + ' ')


// Her yere gidip formüllerinizi değiştirmeniz gerekiyor. bunu yapmamak için fonksiyonlardan yaralanıyoruz. Kendi fonksiyonlarımızı yazıyoruz.

// Fonksiyonların en temel amacı kendini tekrar etme prensibidir. Bir kere yazdığınız zaman o kodu bir daha tekrarlamaman gerekyioyr. Don't repat yourself veya dry prensibi bir kere kodu yazdığın zaman tekrarlamama gerekir.
*/

/* Ornek3.

//ismi sayıUret () içine parametreleri yazarız.
function sayiUret(){
    console.log(Math.ceil(Math.random() * 49)) // Ekrana yaz dedik.
}
// fonk. bir tanımdır. Fonksiyonun çalışması için onu çağırmanız gerekiyor.

sayiUret() // sayiUret fonk çalıştır demektir.

*/

/* Ornek4.

function sayiUret(){
    return Math.ceil(Math.random() * 60) //not defined deniyor. Bu kod (Değerini istediğiniz fonk. return ismli keyword denilen anahtar kelimereden yaralanıyoruz.)çalşır ama ataması grektiğini bilmez.
    //Math.ceil(2.1)

    // 1 fonk. sadece 1 return olur. 2 tane return geçebilir ama 1 tanesi çalışır. 1 tanesi çalışır ve fonk. biter.
}

sayiUret()

var sayi1 = sayiUret()
var sayi2 = sayiUret()
var sayi3 = sayiUret()
var sayi4 = sayiUret()
var sayi5 = sayiUret()
var sayi6 = sayiUret()
console.log('Kolon: ' + sayi1 + ' ' + sayi2 + ' ' + sayi3 + ' ' + sayi4 + ' ' + sayi5 + ' ' + sayi6 + ' ')

*/

/*Ornek5.
// Fonk. çalışırken önemli konulardan bir taneside parametrelerdir. (Biz fonk. parametre yollarız.) 

*/
var degisken1 = "Değer"; //fonk dışında buna global alan diyoruz. Aslındda function.js kapsamında tanımlanan bir değişkendir. Dolayısıyla function.js içindeki herkez bu değere yani değişkene ulaşabilir.


function sayiUret(ustLimit = 49) { // Kişi parametre yollmazsa üst limit 49'dur.(Buna default değer denir.)
    var degisken = 'Değer'
    console.log(degisken1) // Biz buna parametrelerin kapsamı olarak adlandırıyoruz.
    return Math.ceil(Math.random() * ustLimit)

}

// Yukarıda ustLimit diye bir değiken tanımladığın ve siz hiçbir şekilde dışarıda geçerli değildir.
//console.log(ustLimit)
//console.log(degisken) // Bu değişkene dışarıdan ulaşma şansınız yoktur.s
console.log(degisken1)
sayiUret()

var sayi1 = sayiUret(100000) // Parametre yollama
var sayi2 = sayiUret()
var sayi3 = sayiUret()
var sayi4 = sayiUret()
var sayi5 = sayiUret()
var sayi6 = sayiUret(49)
console.log('Kolon: ' + sayi1 + ' ' + sayi2 + ' ' + sayi3 + ' ' + sayi4 + ' ' + sayi5 + ' ' + sayi6 + ' ')
// Eğer paramtereye hiçbir değer göndermezsek NaN olur yani hesaplamayamaz üst limit orada undefiend değer olarak geliyor.

// Yani değişkenleri hangi kapsamda, scopeta yada blokta tanımladıysanız. Sadece o kapsamda geçerlidir. 