// 1. Boş dizi oluştur
let sayilar = [];

// 2. 100 adet rastgele sayı üret (0-999 arası)
for (let i = 0; i < 100; i++) {
    let rastgele = Math.floor(Math.random() * 1000);
    sayilar.push(rastgele);
}

// 3. Büyükten küçüğe sırala
sayilar.sort(function(a, b) {
    return b - a;
});

// 4. Div içine yazdır
document.getElementById("sonuc").innerHTML = sayilar.join("<br>");