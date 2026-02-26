function mesajEkle() {

    let input = document.getElementById("mesajInput");
    let mesajMetni = input.value.trim();

    if (mesajMetni === "") {
        alert("Boş mesaj gönderilemez!");
        return;
    }

    // Saat alma
    let simdi = new Date();
    let saat = simdi.getHours().toString().padStart(2, "0");
    let dakika = simdi.getMinutes().toString().padStart(2, "0");
    let saatBilgisi = saat + ":" + dakika;

    // Yeni mesaj div oluşturma
    let mesajDiv = document.createElement("div");
    mesajDiv.className = "mesaj";

    mesajDiv.innerHTML = `
        <img src="https://i.pravatar.cc/30">
        <span>${mesajMetni}</span>
        <span class="saat">${saatBilgisi}</span>
    `;

    document.getElementById("mesajListesi").appendChild(mesajDiv);

    // Input temizleme
    input.value = "";
}