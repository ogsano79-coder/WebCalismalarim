// NAME SEÇİCİ
function nameSecici() {
    // name="kullaniciAdi" olanların ilkini seçer
    document.getElementsByName("kullaniciAdi")[0].style.backgroundColor = "red";
}


// TAGNAME SEÇİCİ
function tagSecici() {
    // üçüncü span (index 2)
    document.getElementsByTagName("span")[2].style.borderBottomStyle = "solid";
    document.getElementsByTagName("span")[2].style.borderBottomWidth = "2px";
}