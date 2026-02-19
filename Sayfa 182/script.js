function modAyarla() {
    const evet = document.getElementById("evet").checked;
    const body = document.body;

    if (evet) {
        body.classList.add("dark-mode");
    } else {
        body.classList.remove("dark-mode");
    }
}
