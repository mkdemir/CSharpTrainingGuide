function sayiUret(ustLimit = 49) {
    return Math.ceil(Math.random() * ustLimit);
}


// Sayısal loto 1 kolon 6 tane oluşuyor.

for (var i = 1; i <= 8; i++) {
	console.log("Kolon: " + i)
    for (var j = 1; j <= 6; j++) {
        console.log(sayiUret());
    }
}

